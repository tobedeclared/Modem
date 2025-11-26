using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

using Modem.Controls;
using Modem.Interfaces;
using Modem.Properties;

namespace Modem.Pages
{
    public partial class ImeiPage : UserControl
    {
        private IModemService modem;
        private NotificationTablet notification;

        private Random random = new Random();

        private Bitmap copy_active;
        private Bitmap copy_passive;
        private Bitmap mask_active;
        private Bitmap mask_passive;

        private bool isModem;
        private string imei;
        private readonly string[] imei_default = new string[2] { "868842063694018", "868842063694000" };

        public ImeiPage(IModemService modem, NotificationTablet notification)
        {
            this.modem = modem;
            this.notification = notification;
            imei = "";
            isModem = false;

            copy_active = Resources.copyBtn_active;
            copy_passive = Resources.copyBtn;
            mask_active = Resources.maskBtn_active;
            mask_passive = Resources.maskBtn;

            InitializeComponent();

            modem.OnDataReceived += DataReceived;
            modem.OnError += OnError;
            Disposed += OnDisposed;
        }

        private void DistributeData(string response)
        {
            if (String.IsNullOrEmpty(response))
            {
                notification.Set("Ошибка", "Невозможно получить данные с устройства.");
                isModem = false;
                return;
            }

            if (response.Contains("FM350-GL")) isModem = true;
            if (response.Contains("OK")) notification.Success();
            if (response.Contains("ERROR")) notification.Failure();
            if (response.Contains("+EGMREXT:PASS")) notification.Success();

            if (response.Contains("+CGSN:"))
            {
                imei = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("OK", "").Replace("\"","").Trim();
                ResultModemImeiLabel.Text = imei + "¹";
            }
        }
        private void SendData()
        {
            modem.WriteData($"AT+EGMREXT=1,7,\"{imei}\"", notification);
        }
        private void RefreshData()
        {
            ImeiValueTextBox.Clear();
            modem.WriteData("AT+CGSN?", notification);
        }
        private void Imei_Changed(object sender, EventArgs e)
        {
            if (ImeiValueTextBox.Text.Length == 15)
            {
                imei = ImeiValueTextBox.Text;
            }
        }
        private void Imei_KeyboardInput(object sender, KeyPressEventArgs e)
        {
            if (isModem)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (isModem)
            {
                Button Current = (Button)sender;
                switch (Current.TabIndex)
                {
                    case 2:
                        if ((ImeiValueTextBox.Text != null && ImeiValueTextBox.Text.Length == 15) 
                            || (ImeiValueTextBox.Text.Length == 0 && imei.Length == 15)) 
                            SendData();
                        else notification.Set("Ошибка", "В значении IMEI должно быть ровно 15 символов (цифр).");
                        break;
                    case 3: RefreshData(); break;
                    case 4:
                        imei = imei_default[random.Next(2)];
                        ResultModemImeiLabel.Text = imei + "¹";
                        break;
                    case 5:
                        Clipboard.SetText(ResultModemImeiLabel.Text.Substring(0, ResultModemImeiLabel.Text.Length - 1));
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
                    case 2: Current.BackColor = Color.FromArgb(250, 222, 189); break;
                    case 3: Current.ForeColor = Color.FromArgb(215, 218, 187); break;
                    case 4:
                        Current.Image = mask_active;
                        Current.BackColor = Color.FromArgb(250, 222, 189);
                        Current.ForeColor = Color.FromArgb(45, 42, 38);
                        break;
                    case 5: Current.Image = copy_active; break;
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
                    case 2: Current.BackColor = Color.FromArgb(205, 172, 131); break;
                    case 3: Current.ForeColor = Color.FromArgb(192, 172, 129); break;
                    case 4:
                        Current.Image = mask_passive;
                        Current.BackColor = Color.FromArgb(17, 17, 18);
                        Current.ForeColor = Color.FromArgb(192, 172, 129);
                        break;
                    case 5: Current.Image = copy_passive; break;
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
            copy_active?.Dispose();
            copy_passive?.Dispose();
            mask_active?.Dispose();
            mask_passive?.Dispose();
        }
        private void Page_Load(object sender, EventArgs e)
        {
            modem.WriteData("AT+CGMM;+CGSN?", notification);
        }
    }
}