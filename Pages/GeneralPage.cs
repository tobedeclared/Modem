using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

using Modem.Controls;
using Modem.Interfaces;
using Modem.Properties;

namespace Modem.Pages
{
    public partial class GeneralPage : UserControl
    {
        private IModemService modem;
        private NotificationTablet notification;

        private Bitmap copy_active;
        private Bitmap copy_passive;

        private bool isModem;
        string[] values;

        public GeneralPage(IModemService instance, NotificationTablet notification)
        {
            modem = instance;
            this.notification = notification;
            isModem = false;

            copy_active = Resources.copyBtn_active;
            copy_passive = Resources.copyBtn;

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

            if (response.Contains("FM350-GL") && isModem == false)
            {
                isModem = true;
                values = new string[5] { "", "", "", "", "" };
                modem.WriteData("AT+GMI?", notification);
            }
            else if (isModem == false) return;

            if (response.Contains("OK")) notification.Success();
            if (response.Contains("ERROR")) notification.Failure();

            if (response.Contains("+GMI:"))
            {
                values[0] = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("\"", "").Replace("OK", "").Trim();
                ManufacValueButton.Text = values[0];

                modem.WriteData("AT+CGMM?", notification);
            }

            if (response.Contains("+CGMM:"))
            {
                Debug.WriteLine($"in CGMM: {response}");
                values[1] = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("\"", "").Replace("OK", "").Trim();
                ModelValueButton.Text = values[1];
                ModelLabel.Text = values[1];

                modem.WriteData("AT+GTMCFWVER?", notification);
            }

            if (response.Contains("+GTMCFWVER:"))
            {
                values[2] = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("\"", "").Replace("OK", "").Trim();
                FirmwareValueButton.Text = values[2];

                modem.WriteData("AT+CFSN?", notification);
            }

            if (response.Contains("+CFSN:"))
            {
                values[3] = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("\"", "").Replace("OK", "").Trim();
                SnValueButton.Text = values[3];
                SnLabel.Text = "S/N: " + values[3];

                modem.WriteData("AT+CGSN?", notification);
                return;
            }

            if (response.Contains("+CGSN:"))
            {
                values[4] = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("\"", "").Replace("OK", "").Trim();
                ImeiValueButton.Text = values[4];
                ImeiLabel.Text = "IMEI: " + values[4];
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (isModem)
            {
                Button Current = (Button)sender;
                string textCopy = values[Current.TabIndex];
                Clipboard.SetText(textCopy);
                notification.Set("Уведомление", "Выбранные данные успешно скопированы.", 3000, true);
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
                Current.Image = copy_active;
            }
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (isModem)
            {
                Button Current = (Button)sender;
                Current.Image = copy_passive;
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
        }
        private void Page_Load(object sender, EventArgs e)
        {
            modem.WriteData("AT+CGMM", notification);
        }
    }
}