namespace Modem.Pages
{
    partial class SettingsPage
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
            this.PortOpenButton = new System.Windows.Forms.Button();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.PortNameLabel = new System.Windows.Forms.Label();
            this.PortBaudRateLabel = new System.Windows.Forms.Label();
            this.PageDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.GetPortNamesButton = new System.Windows.Forms.Button();
            this.PortBaudRateComboBox = new Modem.Controls.CustomComboBox();
            this.PortNameComboBox = new Modem.Controls.CustomComboBox();
            this.SuspendLayout();
            // 
            // PortOpenButton
            // 
            this.PortOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PortOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(131)))));
            this.PortOpenButton.Enabled = false;
            this.PortOpenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(222)))), ((int)(((byte)(189)))));
            this.PortOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortOpenButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PortOpenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.PortOpenButton.Location = new System.Drawing.Point(777, 604);
            this.PortOpenButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PortOpenButton.MaximumSize = new System.Drawing.Size(218, 51);
            this.PortOpenButton.Name = "PortOpenButton";
            this.PortOpenButton.Size = new System.Drawing.Size(218, 51);
            this.PortOpenButton.TabIndex = 1;
            this.PortOpenButton.Text = "Открыть порт";
            this.PortOpenButton.UseVisualStyleBackColor = false;
            this.PortOpenButton.Click += new System.EventHandler(this.Button_Click);
            this.PortOpenButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PortOpenButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
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
            this.PageTitleLabel.Size = new System.Drawing.Size(150, 67);
            this.PageTitleLabel.TabIndex = 12;
            this.PageTitleLabel.Text = "Настройки";
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PortNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortNameLabel.Location = new System.Drawing.Point(183, 167);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(296, 28);
            this.PortNameLabel.TabIndex = 13;
            this.PortNameLabel.Text = "Имя последовательного порта";
            // 
            // PortBaudRateLabel
            // 
            this.PortBaudRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PortBaudRateLabel.AutoSize = true;
            this.PortBaudRateLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PortBaudRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortBaudRateLabel.Location = new System.Drawing.Point(216, 222);
            this.PortBaudRateLabel.Name = "PortBaudRateLabel";
            this.PortBaudRateLabel.Size = new System.Drawing.Size(263, 28);
            this.PortBaudRateLabel.TabIndex = 14;
            this.PortBaudRateLabel.Text = "Скорость передачи данных";
            // 
            // PageDescriptionTextBox
            // 
            this.PageDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.PageDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PageDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PageDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PageDescriptionTextBox.Location = new System.Drawing.Point(15, 70);
            this.PageDescriptionTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.PageDescriptionTextBox.Multiline = true;
            this.PageDescriptionTextBox.Name = "PageDescriptionTextBox";
            this.PageDescriptionTextBox.Size = new System.Drawing.Size(980, 60);
            this.PageDescriptionTextBox.TabIndex = 19;
            this.PageDescriptionTextBox.Text = "Данный раздел предназначен для настройки параметров последовательного порта, кото" +
    "рый служит инструментом для взаимодействия пользователя с модемом.";
            // 
            // GetPortNamesButton
            // 
            this.GetPortNamesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetPortNamesButton.FlatAppearance.BorderSize = 0;
            this.GetPortNamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GetPortNamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GetPortNamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetPortNamesButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GetPortNamesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.GetPortNamesButton.Location = new System.Drawing.Point(515, 611);
            this.GetPortNamesButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.GetPortNamesButton.Name = "GetPortNamesButton";
            this.GetPortNamesButton.Size = new System.Drawing.Size(256, 36);
            this.GetPortNamesButton.TabIndex = 2;
            this.GetPortNamesButton.Text = "Обновить список портов";
            this.GetPortNamesButton.UseVisualStyleBackColor = false;
            this.GetPortNamesButton.Click += new System.EventHandler(this.Button_Click);
            this.GetPortNamesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.GetPortNamesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PortBaudRateComboBox
            // 
            this.PortBaudRateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PortBaudRateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.PortBaudRateComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortBaudRateComboBox.BorderSize = 1;
            this.PortBaudRateComboBox.DisplayMember = "ToString()";
            this.PortBaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortBaudRateComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PortBaudRateComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortBaudRateComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortBaudRateComboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.PortBaudRateComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.PortBaudRateComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortBaudRateComboBox.Location = new System.Drawing.Point(485, 220);
            this.PortBaudRateComboBox.MaximumSize = new System.Drawing.Size(315, 36);
            this.PortBaudRateComboBox.MinimumSize = new System.Drawing.Size(315, 36);
            this.PortBaudRateComboBox.Name = "PortBaudRateComboBox";
            this.PortBaudRateComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.PortBaudRateComboBox.Size = new System.Drawing.Size(315, 36);
            this.PortBaudRateComboBox.TabIndex = 17;
            this.PortBaudRateComboBox.Texts = "";
            this.PortBaudRateComboBox.ValueMember = "ToString()";
            // 
            // PortNameComboBox
            // 
            this.PortNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PortNameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.PortNameComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortNameComboBox.BorderSize = 1;
            this.PortNameComboBox.DisplayMember = "ToString()";
            this.PortNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PortNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortNameComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortNameComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.PortNameComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PortNameComboBox.Location = new System.Drawing.Point(485, 164);
            this.PortNameComboBox.MaximumSize = new System.Drawing.Size(315, 36);
            this.PortNameComboBox.MinimumSize = new System.Drawing.Size(315, 36);
            this.PortNameComboBox.Name = "PortNameComboBox";
            this.PortNameComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.PortNameComboBox.Size = new System.Drawing.Size(315, 36);
            this.PortNameComboBox.TabIndex = 16;
            this.PortNameComboBox.Texts = "";
            this.PortNameComboBox.ValueMember = "ToString()";
            this.PortNameComboBox.OnSelectedIndexChanged += new System.EventHandler(this.PortNameComboBox_OnSelectedIndexChanged);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.GetPortNamesButton);
            this.Controls.Add(this.PageDescriptionTextBox);
            this.Controls.Add(this.PortOpenButton);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.PortBaudRateComboBox);
            this.Controls.Add(this.PortNameLabel);
            this.Controls.Add(this.PortNameComboBox);
            this.Controls.Add(this.PortBaudRateLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1020, 680);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(1020, 680);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PortOpenButton;
        private System.Windows.Forms.Label PageTitleLabel;
        private Modem.Controls.CustomComboBox PortBaudRateComboBox;
        private System.Windows.Forms.Label PortNameLabel;
        private Modem.Controls.CustomComboBox PortNameComboBox;
        private System.Windows.Forms.Label PortBaudRateLabel;
        private System.Windows.Forms.TextBox PageDescriptionTextBox;
        private System.Windows.Forms.Button GetPortNamesButton;
    }
}
