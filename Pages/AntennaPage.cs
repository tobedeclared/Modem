using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

using Modem.Controls;
using Modem.Interfaces;

namespace Modem.Pages
{
    public partial class AntennaPage : UserControl
    {
        private IModemService modem;
        private NotificationTablet notification;

        private bool isModem;
        private int selected;
        string[] values;

        public AntennaPage(IModemService modem, NotificationTablet notification)
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
                notification.Set("Ошибка", "Невозможно получить данные с устройства.");
                isModem = false;
                return;
            }
            
            if (response.Contains("FM350-GL")) isModem = true;
            if (response.Contains("OK")) notification.Success();
            if (response.Contains("ERROR")) notification.Failure();

            if (response.Contains("+GTRXPATHEN:"))
            {
                string dataTemp = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("OK", "").Trim();
                if (values == null) values = new string[2] { "", "" };
                values = dataTemp.Split(',');
                ButtonPerformClick(values[1]);
            }
        }
        private void ButtonPerformClick(string key)
        {
            switch (key)
            {
                case "1": RFModeMButton.PerformClick(); break;
                case "2": RFModeDGButton.PerformClick(); break;
                case "4": RFModeM1Button.PerformClick(); break;
                case "8": RFModeM2Button.PerformClick(); break;
                case "15": RFModeAllButton.PerformClick(); break;
            }
        }
        private void SendData()
        {
            modem.WriteData($"AT+GTRXPATHEN={values[0]},{values[1]}", notification);
        }
        private void RefreshData()
        {
            modem.WriteData("AT+GTRXPATHEN?", notification);
        }
        private void ConnectorVisible(string state)
        {
            PigtailM2Picture.Visible = state[0] == '1';
            PigtailM1Picture.Visible = state[1] == '1';
            PigtailDGPicture.Visible = state[2] == '1';
            PigtailMPicture.Visible = state[3] == '1';
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
                    default:
                        RFButtonsPanel.Controls[selected].BackColor = Color.FromArgb(0, 0, 0);
                        selected = RFButtonsPanel.Controls.GetChildIndex(Current);
                        ConnectorVisible((String)Current.Tag);
                        Current.BackColor = Color.FromArgb(105, 88, 67);
                        values[1] = Convert.ToString(Current.TabIndex);
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
                    default: if (Convert.ToString(Current.TabIndex) != values[1]) Current.BackColor = Color.FromArgb(11, 9, 6); break;
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
                    default: if (Convert.ToString(Current.TabIndex) != values[1]) Current.BackColor = Color.FromArgb(0, 0, 0); break;
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
            modem.WriteData("AT+CGMM;+GTRXPATHEN?", notification);
        }
    }
}