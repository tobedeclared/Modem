using System;
using System.Drawing;
using System.Windows.Forms;

using Modem.Controls;
using Modem.Interfaces;

namespace Modem.Pages
{
    public partial class SettingsPage : UserControl
    {
        private IModemService modem;
        private NotificationTablet notification;

        public SettingsPage(IModemService modem, NotificationTablet notification)
        {
            this.modem = modem;
            this.notification = notification;

            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button Current = (Button)sender;
            switch (Current.TabIndex)
            {
                case 1:
                    if (modem.PortIsOpen() == false)
                    {
                        int.TryParse(PortBaudRateComboBox.SelectedItem.ToString(), out int baudRate);
                        modem.SetPortName(PortNameComboBox.SelectedItem.ToString(), baudRate, notification);

                        modem.PortOpen(notification);

                        if (modem.PortIsOpen())
                        {
                            PortOpenButton.Text = "Порт открыт";
                            PortOpenButton.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        modem.PortClose(notification);
                        if (modem.PortIsOpen() == false)
                        {
                            PortOpenButton.Text = "Открыть порт";
                            PortOpenButton.BackColor = Color.FromArgb(205, 172, 131);
                        }
                    }
                    break;
                case 2:
                    PortNameComboBox.Items.Clear();
                    PortNameComboBox.Items.AddRange(modem.GetPortNames(notification));
                    PortNameComboBox.SelectedIndex = 0;
                    break;
            }
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button Current = (Button)sender;

            switch (Current.TabIndex)
            {
                case 1:
                    if (modem.PortIsOpen() == true)
                    {
                        PortOpenButton.Text = "Закрыть порт?";
                        PortOpenButton.FlatAppearance.MouseOverBackColor = Color.Red;
                    }
                    else
                    {
                        PortOpenButton.Text = "Открыть порт?";
                        PortOpenButton.FlatAppearance.MouseOverBackColor = Color.Green;
                    }
                    break;
                case 2:
                    GetPortNamesButton.ForeColor = Color.FromArgb(215, 218, 187);
                    break;
            }
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button Current = (Button)sender;

            switch (Current.TabIndex)
            {
                case 1:
                    if (modem.PortIsOpen() == true)
                    {
                        PortOpenButton.Text = "Порт открыт";
                        PortOpenButton.FlatAppearance.MouseOverBackColor = Color.Green;
                    }
                    else
                    {
                        PortOpenButton.Text = "Открыть порт";
                        PortOpenButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 172, 131);
                    }
                    break;
                case 2:
                    GetPortNamesButton.ForeColor = Color.FromArgb(192, 172, 129);
                    break;
            }

        }
        private void PortNameComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (PortNameComboBox.SelectedItem.ToString().Contains("Нет"))
                PortOpenButton.Enabled = false;
            else
                PortOpenButton.Enabled = true;
        }
        private void SettingsPage_Load(object sender, EventArgs e)
        {
            PortNameComboBox.Items.AddRange(modem.GetPortNames(notification));
            PortNameComboBox.SelectedIndex = 0;
            PortBaudRateComboBox.SelectedIndex = 3;

            if (modem.PortIsOpen() == true)
            {
                PortOpenButton.Enabled = true;
                PortOpenButton.Text = "Порт открыт";
                PortOpenButton.BackColor = Color.Green;
                PortNameComboBox.SelectedIndex = PortNameComboBox.Items.IndexOf(modem.PortName);
                PortBaudRateComboBox.SelectedIndex = PortBaudRateComboBox.Items.IndexOf(modem.BaudRate.ToString());
            }
        }
    }
}