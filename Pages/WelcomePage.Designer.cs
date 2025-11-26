namespace Modem.Pages
{
    partial class WelcomePage
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
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.PageDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.StartTitleLabel = new System.Windows.Forms.Label();
            this.StartDescriptionBox = new System.Windows.Forms.TextBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PageDescriptionTextBox
            // 
            this.PageDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.PageDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PageDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PageDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PageDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PageDescriptionTextBox.Location = new System.Drawing.Point(15, 70);
            this.PageDescriptionTextBox.Multiline = true;
            this.PageDescriptionTextBox.Name = "PageDescriptionTextBox";
            this.PageDescriptionTextBox.ReadOnly = true;
            this.PageDescriptionTextBox.Size = new System.Drawing.Size(980, 91);
            this.PageDescriptionTextBox.TabIndex = 30;
            this.PageDescriptionTextBox.TabStop = false;
            this.PageDescriptionTextBox.Text = resources.GetString("PageDescriptionTextBox.Text");
            // 
            // PageTitleLabel
            // 
            this.PageTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageTitleLabel.AutoSize = true;
            this.PageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PageTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(131)))));
            this.PageTitleLabel.Location = new System.Drawing.Point(15, 0);
            this.PageTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PageTitleLabel.Name = "PageTitleLabel";
            this.PageTitleLabel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.PageTitleLabel.Size = new System.Drawing.Size(789, 67);
            this.PageTitleLabel.TabIndex = 29;
            this.PageTitleLabel.Text = "«Добро пожаловать» - Центр управления модемами Fibocom";
            // 
            // StartTitleLabel
            // 
            this.StartTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTitleLabel.AutoSize = true;
            this.StartTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.StartTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(131)))));
            this.StartTitleLabel.Location = new System.Drawing.Point(15, 183);
            this.StartTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StartTitleLabel.Name = "StartTitleLabel";
            this.StartTitleLabel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.StartTitleLabel.Size = new System.Drawing.Size(191, 62);
            this.StartTitleLabel.TabIndex = 31;
            this.StartTitleLabel.Text = "Начните работу";
            // 
            // StartDescriptionBox
            // 
            this.StartDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.StartDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartDescriptionBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartDescriptionBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StartDescriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.StartDescriptionBox.Location = new System.Drawing.Point(15, 248);
            this.StartDescriptionBox.Multiline = true;
            this.StartDescriptionBox.Name = "StartDescriptionBox";
            this.StartDescriptionBox.ReadOnly = true;
            this.StartDescriptionBox.Size = new System.Drawing.Size(980, 63);
            this.StartDescriptionBox.TabIndex = 32;
            this.StartDescriptionBox.TabStop = false;
            this.StartDescriptionBox.Text = "Чтобы воспользоваться основным функционалом данного программного обеспечения пере" +
    "йдите во вкладку «Настройки» (левый нижний угол) бокового меню или же нажмите кн" +
    "опку ниже.";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(131)))));
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(222)))), ((int)(((byte)(189)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.SettingsButton.Location = new System.Drawing.Point(346, 329);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.SettingsButton.MaximumSize = new System.Drawing.Size(316, 51);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(316, 51);
            this.SettingsButton.TabIndex = 41;
            this.SettingsButton.Text = "Перейти в раздел «Настройки»";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.Button_Click);
            this.SettingsButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SettingsButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.NoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.NoteTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.NoteTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.NoteTextBox.Location = new System.Drawing.Point(15, 632);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.Size = new System.Drawing.Size(980, 20);
            this.NoteTextBox.TabIndex = 42;
            this.NoteTextBox.TabStop = false;
            this.NoteTextBox.Text = "Примечание: ПО предоставляется «как есть». Разработчик не несёт ответственности з" +
    "а последствия использования.";
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.StartDescriptionBox);
            this.Controls.Add(this.StartTitleLabel);
            this.Controls.Add(this.PageDescriptionTextBox);
            this.Controls.Add(this.PageTitleLabel);
            this.MinimumSize = new System.Drawing.Size(1020, 680);
            this.Name = "WelcomePage";
            this.Size = new System.Drawing.Size(1020, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PageDescriptionTextBox;
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.Label StartTitleLabel;
        private System.Windows.Forms.TextBox StartDescriptionBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TextBox NoteTextBox;
    }
}
