using System;
using System.Drawing;
using System.Windows.Forms;

using Modem.Forms;

namespace Modem.Pages
{
    public partial class WelcomePage : UserControl
    {
        MainForm parent;

        public WelcomePage(MainForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            parent.GoToSettingsPage();

            if (parent.MainContainer.Controls.Contains(this))
            {
                parent.MainContainer.Panel2.Controls.Remove(this);
                this.Dispose();
            }
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(250, 222, 189);
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(205, 172, 131);
        }
    }
}
