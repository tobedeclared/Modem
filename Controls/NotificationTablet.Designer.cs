namespace Modem.Controls
{
    partial class NotificationTablet
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            timer?.Dispose();
            failureBackground?.Dispose();
            successBackground?.Dispose();

            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.TabletDescriptionLabel2 = new System.Windows.Forms.Label();
            this.TabletDescriptionLabel1 = new System.Windows.Forms.Label();
            this.TabletCloseButton = new System.Windows.Forms.Button();
            this.TabletTitleLabel = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.ContentPanel.BackgroundImage = global::Modem.Properties.Resources.tablet_success;
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Controls.Add(this.TabletDescriptionLabel2);
            this.ContentPanel.Controls.Add(this.TabletDescriptionLabel1);
            this.ContentPanel.Controls.Add(this.TabletCloseButton);
            this.ContentPanel.Controls.Add(this.TabletTitleLabel);
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(10);
            this.ContentPanel.Size = new System.Drawing.Size(500, 130);
            this.ContentPanel.TabIndex = 0;
            // 
            // TabletDescriptionLabel2
            // 
            this.TabletDescriptionLabel2.AutoSize = true;
            this.TabletDescriptionLabel2.BackColor = System.Drawing.Color.Transparent;
            this.TabletDescriptionLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TabletDescriptionLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TabletDescriptionLabel2.Location = new System.Drawing.Point(11, 71);
            this.TabletDescriptionLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.TabletDescriptionLabel2.Name = "TabletDescriptionLabel2";
            this.TabletDescriptionLabel2.Size = new System.Drawing.Size(74, 23);
            this.TabletDescriptionLabel2.TabIndex = 6;
            this.TabletDescriptionLabel2.Text = "Ошибка";
            this.TabletDescriptionLabel2.Visible = false;
            // 
            // TabletDescriptionLabel1
            // 
            this.TabletDescriptionLabel1.AutoSize = true;
            this.TabletDescriptionLabel1.BackColor = System.Drawing.Color.Transparent;
            this.TabletDescriptionLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TabletDescriptionLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TabletDescriptionLabel1.Location = new System.Drawing.Point(11, 48);
            this.TabletDescriptionLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.TabletDescriptionLabel1.Name = "TabletDescriptionLabel1";
            this.TabletDescriptionLabel1.Size = new System.Drawing.Size(74, 23);
            this.TabletDescriptionLabel1.TabIndex = 5;
            this.TabletDescriptionLabel1.Text = "Ошибка";
            // 
            // TabletCloseButton
            // 
            this.TabletCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.TabletCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabletCloseButton.FlatAppearance.BorderSize = 0;
            this.TabletCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TabletCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TabletCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabletCloseButton.Image = global::Modem.Properties.Resources.closeBtn;
            this.TabletCloseButton.Location = new System.Drawing.Point(450, 13);
            this.TabletCloseButton.Name = "TabletCloseButton";
            this.TabletCloseButton.Size = new System.Drawing.Size(35, 28);
            this.TabletCloseButton.TabIndex = 3;
            this.TabletCloseButton.UseVisualStyleBackColor = false;
            this.TabletCloseButton.Click += new System.EventHandler(this.TabletCloseButton_Click);
            // 
            // TabletTitleLabel
            // 
            this.TabletTitleLabel.AutoSize = true;
            this.TabletTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TabletTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabletTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TabletTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(131)))));
            this.TabletTitleLabel.Location = new System.Drawing.Point(10, 10);
            this.TabletTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TabletTitleLabel.Name = "TabletTitleLabel";
            this.TabletTitleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TabletTitleLabel.Size = new System.Drawing.Size(87, 38);
            this.TabletTitleLabel.TabIndex = 2;
            this.TabletTitleLabel.Text = "Ошибка";
            // 
            // NotificationTablet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Name = "NotificationTablet";
            this.Size = new System.Drawing.Size(500, 130);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label TabletTitleLabel;
        private System.Windows.Forms.Button TabletCloseButton;
        private System.Windows.Forms.Label TabletDescriptionLabel1;
        private System.Windows.Forms.Label TabletDescriptionLabel2;
    }
}
