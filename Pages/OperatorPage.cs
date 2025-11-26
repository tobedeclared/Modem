using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

using Modem.Controls;
using Modem.Interfaces;

namespace Modem.Pages
{
    public partial class OperatorPage : UserControl
    {
        private IModemService modem;
        private NotificationTablet notification;

        private bool isModem;

        private string rat;
        private string apn;
        private string[] credentials = { "", "test", "test", "test" };

        public OperatorPage(IModemService instance, NotificationTablet notification)
        {
            modem = instance;
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

            if (response.Contains("FM350-GL"))
            {
                isModem = true;
                modem.WriteData("AT+GTACT?", notification);
            } else if (isModem == false) return;

            if (response.Contains("OK")) notification.Success();
            if (response.Contains("ERROR")) notification.Failure();

            if (response.Contains("+GTACT:"))
            {
                //Debug.WriteLine($"{response}");
                string data = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("OK", "").Trim();
                string[] values = data.Split(',');
                rat = values[0];
                
                EnableModules(false);
                SelectRatButton(rat);

                modem.WriteData("AT+COPS?", notification);
            }

            if (response.Contains("+COPS:"))
            {
                //Debug.WriteLine($"{response}");
                string data = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("OK", "").Replace("\"", "").Trim();
                string[] values = data.Split(',');
                if (values[2].Length == 5)
                {
                    credentials[0] = values[2];
                    PlmnTextBox.Text = credentials[0];
                }
                modem.WriteData("AT+CGAUTH?", notification);
            }

            if (response.Contains("+CGAUTH:"))
            {
                //Debug.WriteLine($"{response}");
                string data = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("OK", "").Replace("\"", "").Trim();
                credentials = data.Split(',');
                                
                SelectAuthButton(credentials[1]);
                
                LoginTextBox.Text = $"{credentials[2]}";
                PassTextBox.Text = $"{credentials[3]}";

                modem.WriteData("AT+CGDCONT?", notification);
            }

            if (response.Contains("+CGDCONT:"))
            {
                string data = response.Split(':')[1].Replace("\r", "").Replace("\n", "").Replace("\"", "").Replace("OK", "").Trim();
                string[] values = data.Split(',');
                apn = values[2];
                                
                ApnTextBox.Text = $"{apn}";
            }
        }
        private void SelectRatButton(string value)
        {
            switch (value)
            {
                //case "1": Rat3GButton.PerformClick(); break;
                case "2": Rat4GButton.PerformClick(); EnableModules(true); break;
                case "4": Rat4GButton.PerformClick(); EnableModules(true); break;
                case "10": Rat4GButton.PerformClick(); EnableModules(true); break;
                case "14": Rat5GButton.PerformClick(); break;
                case "16": Rat5GButton.PerformClick(); break;
                case "17": Rat5GButton.PerformClick(); break;
                case "20": Rat5GButton.PerformClick(); break;

            }
        }
        private void SelectAuthButton(string value)
        {
            switch (value)
            {
                case "0": AuthNoButton.PerformClick(); break;
                case "1": AuthChapButton.PerformClick(); break;
                case "2": AuthPapButton.PerformClick(); break;
            }
        }
        private void EnableModules(bool flag)
        {
            ApnTextBox.Enabled = flag;
            PlmnTextBox.Enabled = flag;
            LoginTextBox.Enabled = flag;
            PassTextBox.Enabled = flag;

            AuthNoButton.Enabled = flag;
            AuthChapButton.Enabled = flag;
            AuthPapButton.Enabled = flag;
        }
        private void SendData()
        {
            if (rat == "2")
            {
                if (PlmnTextBox.Text.Length == 5)
                {
                    modem.WriteData($"AT+GTACT={rat};+CGAUTH=0,{credentials[1]},\"{credentials[2]}\",\"{credentials[3]}\";+COPS=4,2,\"{PlmnTextBox.Text}\";+CGDCONT=0,\"IPV4V6\",\"{apn}\"", notification);
                } else
                {
                    modem.WriteData($"AT+GTACT={rat};+CGAUTH=0,{credentials[1]},\"{credentials[2]}\",\"{credentials[3]}\"", notification);
                }
            }
            else
            {
                EnableModules(false);
                //Debug.WriteLine($"AT+GTACT={rat}");
                modem.WriteData($"AT+GTACT={rat}", notification);
            }
        }
        private void RefreshData()
        {
            modem.WriteData("AT+GTACT?", notification);
        }
        private void PlmnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isModem)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox Current = (TextBox)sender;
            switch (Current.TabIndex)
            {
                case 35: apn = ApnTextBox.Text; break;
                case 37: credentials[2] = LoginTextBox.Text; break;
                case 38: credentials[3] = PassTextBox.Text; break;
            }
        }
        private void RatButtons(Button button)
        {
            foreach (Control control in RatPanel.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.FromArgb(17, 17, 18);
                    control.ForeColor = Color.FromArgb(192, 172, 129);
                }
            }
            
            button.BackColor = Color.FromArgb(250, 222, 189);
            button.ForeColor = Color.FromArgb(45, 42, 38);

            if (Convert.ToString(button.Tag) != rat)
            {
                rat = Convert.ToString(button.Tag);
            }

            if (button.TabIndex == 2)
            {
                EnableModules(true);
            }
        }
        private void AuthButtons(Button button)
        {
            foreach (Control control in UserPanel.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.FromArgb(17, 17, 18);
                    control.ForeColor = Color.FromArgb(192, 172, 129);
                }
            }
            button.BackColor = Color.FromArgb(250, 222, 189);
            button.ForeColor = Color.FromArgb(45, 42, 38);


            if (Convert.ToString(button.Tag) != credentials[1])
            {
                credentials[1] = Convert.ToString(button.Tag);
            }
        }
        private void SendButton()
        {
            if (rat == "2")
            {
                if (ApnTextBox.Text.Length > 0 && LoginTextBox.Text.Length > 0 && PassTextBox.Text.Length > 0)
                {
                    SendData();
                }
                else
                {
                    notification.Set("Ошибка", "Изменения не были сохранены по причине\n некорректного ввода данных");
                }
            } else
            {
                SendData();
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (isModem)
            {
                Button Current = (Button)sender;
                if (Current.TabIndex <= 3) { RatButtons(Current); return; }
                if (Current.TabIndex >= 4 && Current.TabIndex <= 6) { AuthButtons(Current); return; }
                if (Current.TabIndex == 7) { SendButton(); return; }
                if (Current.TabIndex == 8) { RefreshData(); return; }
            }
            else
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
            modem.WriteData("AT+CGMM", notification);
        }
    }
}