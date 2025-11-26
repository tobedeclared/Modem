using Modem.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Modem.Controls
{
    public partial class NotificationTablet : UserControl
    {
        private MainForm parent;
        private Timer timer;

        private Image failureBackground;
        private Image successBackground;

        public NotificationTablet(MainForm parent)
        {
            this.parent = parent;

            Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            timer = new Timer();
            timer.Tick += TabletCloseButton_Click;

            InitializeComponent();

            failureBackground = Properties.Resources.tablet_failure;
            successBackground = Properties.Resources.tablet_success;
        }

        public void Set(string title, string description, int interval = 3000, bool isSuccess = false)
        {
            TabletTitleLabel.Text = title;
            TabletDescriptionLabel1.Text = description;

            timer.Interval = interval;

            ShowNotification(isSuccess);
        }
        public void Success()
        {
            TabletTitleLabel.Text = "Уведомление";
            TabletDescriptionLabel1.Text = "Данные успешно обновлены.";

            timer.Interval = 3000;

            ShowNotification(true);
        }
        public void Failure()
        {
            TabletTitleLabel.Text = "Ошибка";
            TabletDescriptionLabel1.Text = "Данные не были обновлены.";

            timer.Interval = 3000;

            ShowNotification(true);
        }
        public void ShowNotification(bool isSuccess)
        {
            if (!parent.Controls.Contains(this))
                parent.Controls.Add(this);

            ContentPanel.BackgroundImage = isSuccess ? successBackground : failureBackground;

            Location = new Point(parent.Width - Width - 10, parent.Height - Height - 10);
            BringToFront();
            Visible = true;

            timer.Stop();
            timer.Start();
        }
        private void TabletCloseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Visible = false;
        }
    }
}