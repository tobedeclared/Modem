using System;
using System.Drawing;
using System.Windows.Forms;

using Modem.Classes;
using Modem.Controls;
using Modem.Interfaces;
using Modem.Pages;

namespace Modem.Forms
{
    public partial class MainForm : Form
    {
        private IModemService modem;
        private SettingsPage settingsPage;
        private NotificationTablet notification;

        public SplitContainer MainContainer => MenuAndWorkContainer;

        private Point mousePosition;
        private Bitmap lineImage;

        private int tabIndex;
        private bool menuExpand = true;

        public IModemService ModemService => modem;

        public MainForm()
        {
            modem = new ModemService();
            notification = new NotificationTablet(this);
            settingsPage = new SettingsPage(ModemService, notification);
            lineImage = Properties.Resources.lineBtn;
            InitializeComponent();

            Disposed += OnDisposed;
        }
        public void GoToSettingsPage()
        {
            Page_Open(settingsPage);
        }
        private void ClearSelect(int tabIndex)
        {
            if (modem.PortIsOpen() == true)
            {
                HomeButton.ForeColor = Color.FromArgb(226, 226, 227);
                OperatorButton.ForeColor = Color.FromArgb(226, 226, 227);
                FreqButton.ForeColor = Color.FromArgb(226, 226, 227);
                AntennaButton.ForeColor = Color.FromArgb(226, 226, 227);
                ImeiButton.ForeColor = Color.FromArgb(226, 226, 227);
                SettingsButton.ForeColor = Color.FromArgb(226, 226, 227);
            }
        }
        private void Page_Open(UserControl page)
        {
            if (page is SettingsPage)
            {
                page = settingsPage;
            }

            if (MenuAndWorkContainer.Panel2.Controls.Count > 0)
            {
                var current = MenuAndWorkContainer.Panel2.Controls[0];

                if (!(current is SettingsPage))
                {
                    current.Dispose();
                }

                MenuAndWorkContainer.Panel2.Controls.Remove(current);
            }

            page.Dock = DockStyle.Fill;
            MenuAndWorkContainer.Panel2.Controls.Add(page);
        }
        private void MenuAnimation_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                MenuAndWorkContainer.SplitterDistance -= 19;
                if (MenuAndWorkContainer.SplitterDistance == 70)
                {
                    menuExpand = false;
                    MenuAnimation.Stop();
                }
            }
            else
            {
                MenuAndWorkContainer.SplitterDistance += 19;
                if (MenuAndWorkContainer.SplitterDistance == 260)
                {
                    menuExpand = true;
                    MenuAnimation.Stop();
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            ClearSelect(tabIndex);
            Button Current = (Button)sender;
            tabIndex = Current.TabIndex;

            switch (Current.TabIndex)
            {
                case 1: Close(); break;
                case 2: WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal; break;
                case 3: WindowState = FormWindowState.Minimized; break;
                case 4: MenuAnimation.Start(); break;
                case 5: if (modem.PortIsOpen() == true) Page_Open(new GeneralPage(ModemService, notification)); break;
                case 6: if (modem.PortIsOpen() == true) Page_Open(new OperatorPage(ModemService, notification)); break;
                case 7: if (modem.PortIsOpen() == true) Page_Open(new FrequencyPage(ModemService, notification)); break;
                case 8: if (modem.PortIsOpen() == true) Page_Open(new AntennaPage(ModemService, notification)); break;
                case 9: if (modem.PortIsOpen() == true) Page_Open(new ImeiPage(ModemService, notification)); break;
                case 10: Page_Open(settingsPage); break;
            }

            if (modem.PortIsOpen() == true) Current.ForeColor = Color.FromArgb(241, 208, 168);
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button CurrentButton = (Button)sender;
            switch (CurrentButton.TabIndex)
            {
                case 1: CurrentButton.BackColor = Color.FromArgb(232, 17, 35); break;
                case 2: CurrentButton.BackColor = Color.FromArgb(63, 63, 63); break;
                case 3: CurrentButton.BackColor = Color.FromArgb(63, 63, 63); break;
                default: 
                    CurrentButton.BackgroundImage = lineImage; 
                    CurrentButton.BackColor = Color.FromArgb(26, 27, 30); 
                    break;
            }
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button CurrentButton = (Button)sender;
            switch (CurrentButton.TabIndex)
            {
                case 1: CurrentButton.BackColor = Color.FromArgb(0, 0, 0); break;
                case 2: CurrentButton.BackColor = Color.FromArgb(0, 0, 0); break;
                case 3: CurrentButton.BackColor = Color.FromArgb(0, 0, 0); break;
                default: 
                    CurrentButton.BackgroundImage = null; 
                    CurrentButton.BackColor = Color.FromArgb(17, 17, 18); 
                    break;
            }
        }
        private void OnDisposed(object sender, EventArgs e)
        {
            //modem?.Dispose();
            settingsPage?.Dispose();
            notification?.Dispose();
            lineImage?.Dispose();
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(-e.X, -e.Y);
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mousePosition.X, mousePosition.Y);
                Location = mousePose;
            }
        }
        private void Form_Load(object sender, EventArgs e)
        {
            Page_Open(new WelcomePage(this));
        }
    }
}