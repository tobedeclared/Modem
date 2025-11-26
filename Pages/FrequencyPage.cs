using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

using Modem.Controls;
using Modem.Interfaces;

namespace Modem.Pages
{
    public partial class FrequencyPage : UserControl
    {
        private IModemService modem;
        private NotificationTablet notification;

        private string[] defaultBands;
        private string[] userBands;
        private string[] userBandsBackup;

        private bool isModem;
        private bool isUserChoice = true;

        public FrequencyPage(IModemService modem, NotificationTablet notification)
        {
            this.modem = modem;
            this.notification = notification;
            isModem = false;

            InitializeComponent();

            modem.OnDataReceived += DataReceived;
            modem.OnError += OnError;
            Disposed += OnDisposed;
        }

        private void DistributeData(string response)
        {
            if (String.IsNullOrEmpty(response))
            {
                isModem = false;
                notification.Set("Ошибка", "Невозможно получить данные с вашего устройства.");
                return;
            }

            if (response.Contains("FM350-GL")) isModem = true;
            if (response.Contains("OK")) notification.Success();
            if (response.Contains("ERROR")) notification.Failure();

            if (response.Contains("+GTACT:"))
            {
                string data = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("OK", "").Trim();
                //Debug.WriteLine($"{data}");
                if (isUserChoice == true)
                {
                    userBands = data.Split(',');

                    RatGroupBox.Text = $"Диапазона частот для {DefineRat(userBands[0])} сети";

                    isUserChoice = false;

                    (userBands[1], userBands[2]) = PreferredAct(userBands[0]);
                    
                    userBandsBackup = userBands;

                    modem.WriteData($"AT+GTACT={userBands[0]},{userBands[1]},{userBands[2]},0;+GTACT?", notification);
                }
                else
                {
                    defaultBands = data.Split(',');
                    ResizePanel(defaultBands);

                    FillBandsPanel(defaultBands);
                    SelectBand(defaultBands, userBands);

                    isUserChoice = true;

                    modem.WriteData($"AT+GTACT={BuildCommand(userBands)}", notification);
                }
            }

        }
        private void ResizePanel(string[] bands)
        {
            BandsFlowLayoutPanel.Size = new System.Drawing.Size(927, 50);
            RatGroupBox.Size = new System.Drawing.Size(977, 102);
            int count_strings = bands.Length / 14;
            BandsFlowLayoutPanel.Size = new Size(BandsFlowLayoutPanel.Size.Width, BandsFlowLayoutPanel.Size.Height + count_strings * 46);
            RatGroupBox.Size = new Size(RatGroupBox.Size.Width, RatGroupBox.Size.Height + count_strings * 46);
        }
        private string DefineRat(string rat)
        {
            string redefineRat;
            switch(rat)
            {
                case "1": redefineRat = "3G";  break;
                case "2": redefineRat = "4G"; break;
                case "4": redefineRat = "3G/4G"; break;
                case "10": redefineRat = "3G/4G/5G"; break;
                case "14": redefineRat = "5G"; break;
                case "16": redefineRat = "3G/5G"; break;
                case "17": redefineRat = "4G/5G"; break;
                default: redefineRat = "3G/4G/5G"; break;
            }
            return redefineRat;
        }
        private (string preferred1, string preferred2) PreferredAct(string rat)
        {
            string preferred1;
            string preferred2;

            switch (rat)
            {
                case "1": preferred1 = "2"; preferred2 = "2"; break;  // UTMTS
                case "2": preferred1 = "3"; preferred2 = "3"; break;  // LTE
                case "4": preferred1 = "3"; preferred2 = "2"; break;  // LTE/UMTS
                case "10": preferred1 = "3"; preferred2 = "2"; break; // LTE/UMTS
                case "14": preferred1 = "6"; preferred2 = "6"; break; // NR-RAN
                case "16": preferred1 = "6"; preferred2 = "2"; break; // NR-RAN/WCDMA
                case "17": preferred1 = "6"; preferred2 = "3"; break; // NR-RAN/LTE
                default: preferred1 = "6"; preferred2 = "3"; break;   // NR-RAN/WCDMA/LTE 
            }

            return (preferred1, preferred2);
        }
        private string BuildCommand(string[] bands)
        {
            (string preferred1, string preferred2) = PreferredAct(bands[0]);
            string command = $"{bands[0]},{preferred1},{preferred2},";

            for (int index = 3; index < bands.Length; index++)
            {
                if (index + 1 != bands.Length)
                {
                    command += bands[index] + ",";
                } else
                {
                    command += bands[index];
                }
            }

            return command;
        }
        private void SelectBand(string[] defaultBands, string[] userBands)
        {
            foreach (Button current in BandsFlowLayoutPanel.Controls)
            {
                if (userBands.Skip(3).Contains((String)current.Tag))
                {
                    current.BackColor = Color.FromArgb(250, 222, 189);
                    current.ForeColor = Color.FromArgb(45, 42, 38);
                    current.TabStop = true;
                }
            }
        }
        private void FillBandsPanel(string[] bands)
        {
            for (int index = 3; index < bands.Length; index++)
            {
                string currentBand = bands[index];

                // Проверяем, есть ли уже кнопка с таким Tag на панели
                bool alreadyExists = BandsFlowLayoutPanel.Controls
                    .OfType<Button>()
                    .Any(button => button.Tag?.ToString() == currentBand);

                // Если такой кнопки ещё нет — создаём и добавляем
                if (!alreadyExists)
                {
                    BandsFlowLayoutPanel.Controls.Add(BandButton(currentBand));
                }
            }
        }
        private Button BandButton(string name, bool selected = false)
        {
            Button Band = new Button();

            Band.Size = new System.Drawing.Size(60, 40);

            Band.BackColor = Color.FromArgb(17, 17, 18);
            Band.ForeColor = Color.FromArgb(205, 172, 131);

            Band.Font = new System.Drawing.Font("Segoe UI", 10F);
            Band.Name = "Band" + name + "Button";

            Band.Text = ExtractBandSuffix(name);
            Band.Tag = name;

            Band.FlatAppearance.BorderColor = Color.FromArgb(205, 172, 131);
            Band.FlatStyle = FlatStyle.Flat;

            Band.TabStop = false;

            Band.Click += Button_Click;
            Band.MouseEnter += Button_MouseEnter;
            Band.MouseLeave += Button_MouseLeave;

            return Band;
        }
        private string ExtractBandSuffix(string input)
        {
            string result;
            switch(input.Length)
            {
                case 1: result = "B" + input; break;
                case 3: 
                    result = input.Substring(input.Length - 2);
                    if (result.StartsWith("0")) result = "B" + result.Substring(1); 
                    else result = "B" + result;
                    break;
                case 4: result = "B" + input.Substring(input.Length - 2); break;
                default: result = input; break;
            }
            return result;
        }
        private void SendData()
        {
            if (userBands.Length >= 4)
            {
                userBandsBackup = userBands;
                modem.WriteData($"AT+GTACT={BuildCommand(userBands)}", notification);
            } else
            {
                notification.Set("Ошибка", "Должен быть выбран хотя бы 1 бэнд.");
            } 

        }
        private void ResetData()
        {
            foreach (Control ctrl in BandsFlowLayoutPanel.Controls)
            {
                if (ctrl is Button button)
                {
                    button.Click -= Button_Click;
                    button.MouseEnter -= Button_MouseEnter;
                    button.MouseLeave -= Button_MouseLeave;
                }
            }
            BandsFlowLayoutPanel.Controls.Clear();

            (userBands[1], userBands[2]) = PreferredAct(userBands[0]);
            modem.WriteData($"AT+GTACT={userBands[0]},{userBands[1]},{userBands[2]},0;+GTACT?", notification);
        }
        private void RefreshData()
        {
            foreach (Control ctrl in BandsFlowLayoutPanel.Controls)
            {
                if (ctrl is Button button)
                {
                    button.Click -= Button_Click;
                    button.MouseEnter -= Button_MouseEnter;
                    button.MouseLeave -= Button_MouseLeave;
                }
            }
            BandsFlowLayoutPanel.Controls.Clear();

            (userBands[1], userBands[2]) = PreferredAct(userBands[0]);
            
            modem.WriteData($"AT+GTACT={BuildCommand(userBandsBackup)};+GTACT?", notification);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (isModem)
            {
                Button Current = (Button)sender;
                switch (Current.TabIndex)
                {
                    case 40: SendData(); break;
                    case 41: RefreshData(); break;
                    case 42: ResetData(); break;
                    default:
                        if (Current.TabStop == true)
                        {
                            Current.BackColor = Color.FromArgb(17, 17, 18);
                            Current.ForeColor = Color.FromArgb(205, 172, 131);
                            Current.TabStop = false;
                            userBands = userBands.Where(band => band != (String)Current.Tag).ToArray();
                        }
                        else
                        {
                            Current.BackColor = Color.FromArgb(250, 222, 189);
                            Current.ForeColor = Color.FromArgb(45, 42, 38);
                            Current.TabStop = true;
                            userBands = userBands.Append((string)Current.Tag).ToArray();
                        }
                        break;
                }
            } else
            {
                notification.Set("Ошибка", "Данного устройства нет в базе данных.");
            }
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (isModem)
            {
                Button Current = (Button)sender;
                switch (Current.TabIndex)
                {
                    case 40: Current.BackColor = Color.FromArgb(250, 222, 189); break;
                    case 41: Current.ForeColor = Color.FromArgb(215, 218, 187); break;
                    case 42: Current.ForeColor = Color.FromArgb(215, 218, 187); break;
                    default:
                        Current.BackColor = Color.FromArgb(250, 222, 189);
                        Current.ForeColor = Color.FromArgb(45, 42, 38);
                        break;
                }
            }
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (isModem)
            {
                Button Current = (Button)sender;
                switch (Current.TabIndex)
                {
                    case 40: Current.BackColor = Color.FromArgb(205, 172, 131); break;
                    case 41: Current.ForeColor = Color.FromArgb(192, 172, 129); break;
                    case 42: Current.ForeColor = Color.FromArgb(192, 172, 129); break;
                    default:
                        if (Current.TabStop == false)
                        {
                            Current.BackColor = Color.FromArgb(17, 17, 18);
                            Current.ForeColor = Color.FromArgb(205, 172, 131);
                        }
                        break;
                }
            }
        }
        private void DataReceived(string data)
        {
            this.Invoke((MethodInvoker)delegate
            {
                //Debug.WriteLine($"От модема: {data}");
                DistributeData(data);
            });
        }
        private void OnError(string errorMessage)
        {
            this.Invoke((MethodInvoker)delegate
            {
                notification.Set("Ошибка", errorMessage);
            });
        }
        private void OnDisposed(object sender, EventArgs e)
        {
            if (modem != null)
            {
                modem.OnDataReceived -= DataReceived;
                modem.OnError -= OnError;
            }
        }
        private void Page_Load(object sender, EventArgs e)
        {
            modem.WriteData("AT+CGMM;+GTACT?", notification);
        }
    }
}