namespace Modem.Pages
{
    partial class AntennaPage
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
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.ModeRFPanel = new System.Windows.Forms.Panel();
            this.RFModeDecriptionLabel = new System.Windows.Forms.Label();
            this.RFButtonsPanel = new System.Windows.Forms.Panel();
            this.RFModeAllButton = new System.Windows.Forms.Button();
            this.RFModeM2Button = new System.Windows.Forms.Button();
            this.RFModeM1Button = new System.Windows.Forms.Button();
            this.RFModeDGButton = new System.Windows.Forms.Button();
            this.RFModeMButton = new System.Windows.Forms.Button();
            this.ModeRFTitlePanel = new Modem.Controls.BorderedPanel();
            this.RFModeTitleLabel = new System.Windows.Forms.Label();
            this.PigtailMPicture = new System.Windows.Forms.PictureBox();
            this.ModemPartPicture = new System.Windows.Forms.PictureBox();
            this.PigtailM1Picture = new System.Windows.Forms.PictureBox();
            this.PigtailM2Picture = new System.Windows.Forms.PictureBox();
            this.PigtailDGPicture = new System.Windows.Forms.PictureBox();
            this.PageDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SaveValuesButton = new System.Windows.Forms.Button();
            this.ResetValuesButton = new System.Windows.Forms.Button();
            this.ModeRFPanel.SuspendLayout();
            this.RFButtonsPanel.SuspendLayout();
            this.ModeRFTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PigtailMPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModemPartPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigtailM1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigtailM2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigtailDGPicture)).BeginInit();
            this.SuspendLayout();
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
            this.PageTitleLabel.Size = new System.Drawing.Size(509, 67);
            this.PageTitleLabel.TabIndex = 20;
            this.PageTitleLabel.Text = "Конфигурация RF-разъёмов устройства";
            // 
            // ModeRFPanel
            // 
            this.ModeRFPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModeRFPanel.BackColor = System.Drawing.Color.Black;
            this.ModeRFPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModeRFPanel.Controls.Add(this.RFModeDecriptionLabel);
            this.ModeRFPanel.Controls.Add(this.RFButtonsPanel);
            this.ModeRFPanel.Controls.Add(this.ModeRFTitlePanel);
            this.ModeRFPanel.Location = new System.Drawing.Point(516, 138);
            this.ModeRFPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ModeRFPanel.Name = "ModeRFPanel";
            this.ModeRFPanel.Size = new System.Drawing.Size(408, 420);
            this.ModeRFPanel.TabIndex = 22;
            // 
            // RFModeDecriptionLabel
            // 
            this.RFModeDecriptionLabel.AutoSize = true;
            this.RFModeDecriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RFModeDecriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RFModeDecriptionLabel.ForeColor = System.Drawing.Color.White;
            this.RFModeDecriptionLabel.Location = new System.Drawing.Point(0, 57);
            this.RFModeDecriptionLabel.Name = "RFModeDecriptionLabel";
            this.RFModeDecriptionLabel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.RFModeDecriptionLabel.Size = new System.Drawing.Size(329, 43);
            this.RFModeDecriptionLabel.TabIndex = 33;
            this.RFModeDecriptionLabel.Text = "Выберите режим подключения антенн";
            // 
            // RFButtonsPanel
            // 
            this.RFButtonsPanel.Controls.Add(this.RFModeAllButton);
            this.RFButtonsPanel.Controls.Add(this.RFModeM2Button);
            this.RFButtonsPanel.Controls.Add(this.RFModeM1Button);
            this.RFButtonsPanel.Controls.Add(this.RFModeDGButton);
            this.RFButtonsPanel.Controls.Add(this.RFModeMButton);
            this.RFButtonsPanel.Location = new System.Drawing.Point(8, 110);
            this.RFButtonsPanel.Name = "RFButtonsPanel";
            this.RFButtonsPanel.Size = new System.Drawing.Size(390, 300);
            this.RFButtonsPanel.TabIndex = 32;
            // 
            // RFModeAllButton
            // 
            this.RFModeAllButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RFModeAllButton.FlatAppearance.BorderSize = 0;
            this.RFModeAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RFModeAllButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RFModeAllButton.ForeColor = System.Drawing.Color.White;
            this.RFModeAllButton.Location = new System.Drawing.Point(0, 240);
            this.RFModeAllButton.Name = "RFModeAllButton";
            this.RFModeAllButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.RFModeAllButton.Size = new System.Drawing.Size(390, 60);
            this.RFModeAllButton.TabIndex = 15;
            this.RFModeAllButton.Tag = "1111";
            this.RFModeAllButton.Text = "Разьёмы M + M1 + M2 + D/G";
            this.RFModeAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFModeAllButton.UseVisualStyleBackColor = true;
            this.RFModeAllButton.Click += new System.EventHandler(this.Button_Click);
            this.RFModeAllButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.RFModeAllButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // RFModeM2Button
            // 
            this.RFModeM2Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.RFModeM2Button.FlatAppearance.BorderSize = 0;
            this.RFModeM2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RFModeM2Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RFModeM2Button.ForeColor = System.Drawing.Color.White;
            this.RFModeM2Button.Location = new System.Drawing.Point(0, 180);
            this.RFModeM2Button.Name = "RFModeM2Button";
            this.RFModeM2Button.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.RFModeM2Button.Size = new System.Drawing.Size(390, 60);
            this.RFModeM2Button.TabIndex = 8;
            this.RFModeM2Button.Tag = "1000";
            this.RFModeM2Button.Text = "Разьём MIMO AUX (M2)";
            this.RFModeM2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFModeM2Button.UseVisualStyleBackColor = true;
            this.RFModeM2Button.Click += new System.EventHandler(this.Button_Click);
            this.RFModeM2Button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.RFModeM2Button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // RFModeM1Button
            // 
            this.RFModeM1Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.RFModeM1Button.FlatAppearance.BorderSize = 0;
            this.RFModeM1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RFModeM1Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RFModeM1Button.ForeColor = System.Drawing.Color.White;
            this.RFModeM1Button.Location = new System.Drawing.Point(0, 120);
            this.RFModeM1Button.Name = "RFModeM1Button";
            this.RFModeM1Button.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.RFModeM1Button.Size = new System.Drawing.Size(390, 60);
            this.RFModeM1Button.TabIndex = 4;
            this.RFModeM1Button.Tag = "0100";
            this.RFModeM1Button.Text = "Разьём MIMO MAIN (M1)";
            this.RFModeM1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFModeM1Button.UseVisualStyleBackColor = true;
            this.RFModeM1Button.Click += new System.EventHandler(this.Button_Click);
            this.RFModeM1Button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.RFModeM1Button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // RFModeDGButton
            // 
            this.RFModeDGButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RFModeDGButton.FlatAppearance.BorderSize = 0;
            this.RFModeDGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RFModeDGButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RFModeDGButton.ForeColor = System.Drawing.Color.White;
            this.RFModeDGButton.Location = new System.Drawing.Point(0, 60);
            this.RFModeDGButton.Name = "RFModeDGButton";
            this.RFModeDGButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.RFModeDGButton.Size = new System.Drawing.Size(390, 60);
            this.RFModeDGButton.TabIndex = 2;
            this.RFModeDGButton.Tag = "0010";
            this.RFModeDGButton.Text = "Разьём D/G";
            this.RFModeDGButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFModeDGButton.UseVisualStyleBackColor = true;
            this.RFModeDGButton.Click += new System.EventHandler(this.Button_Click);
            this.RFModeDGButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.RFModeDGButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // RFModeMButton
            // 
            this.RFModeMButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RFModeMButton.FlatAppearance.BorderSize = 0;
            this.RFModeMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RFModeMButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RFModeMButton.ForeColor = System.Drawing.Color.White;
            this.RFModeMButton.Location = new System.Drawing.Point(0, 0);
            this.RFModeMButton.Name = "RFModeMButton";
            this.RFModeMButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.RFModeMButton.Size = new System.Drawing.Size(390, 60);
            this.RFModeMButton.TabIndex = 1;
            this.RFModeMButton.Tag = "0001";
            this.RFModeMButton.Text = "Разьём MAIN (M)";
            this.RFModeMButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFModeMButton.UseVisualStyleBackColor = true;
            this.RFModeMButton.Click += new System.EventHandler(this.Button_Click);
            this.RFModeMButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.RFModeMButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ModeRFTitlePanel
            // 
            this.ModeRFTitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.ModeRFTitlePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ModeRFTitlePanel.BorderSide = Modem.Controls.BorderSide.Bottom;
            this.ModeRFTitlePanel.BorderWidth = 3;
            this.ModeRFTitlePanel.Controls.Add(this.RFModeTitleLabel);
            this.ModeRFTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModeRFTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.ModeRFTitlePanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ModeRFTitlePanel.Name = "ModeRFTitlePanel";
            this.ModeRFTitlePanel.Padding = new System.Windows.Forms.Padding(10, 15, 1, 5);
            this.ModeRFTitlePanel.Size = new System.Drawing.Size(406, 57);
            this.ModeRFTitlePanel.TabIndex = 23;
            // 
            // RFModeTitleLabel
            // 
            this.RFModeTitleLabel.AutoSize = true;
            this.RFModeTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RFModeTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RFModeTitleLabel.ForeColor = System.Drawing.Color.White;
            this.RFModeTitleLabel.Location = new System.Drawing.Point(10, 15);
            this.RFModeTitleLabel.Name = "RFModeTitleLabel";
            this.RFModeTitleLabel.Size = new System.Drawing.Size(143, 28);
            this.RFModeTitleLabel.TabIndex = 23;
            this.RFModeTitleLabel.Text = "Режим антенн";
            // 
            // PigtailMPicture
            // 
            this.PigtailMPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PigtailMPicture.Image = global::Modem.Properties.Resources.pigtail_ipex;
            this.PigtailMPicture.Location = new System.Drawing.Point(409, 142);
            this.PigtailMPicture.Name = "PigtailMPicture";
            this.PigtailMPicture.Size = new System.Drawing.Size(46, 116);
            this.PigtailMPicture.TabIndex = 24;
            this.PigtailMPicture.TabStop = false;
            this.PigtailMPicture.Tag = "1";
            this.PigtailMPicture.Visible = false;
            // 
            // ModemPartPicture
            // 
            this.ModemPartPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModemPartPicture.Image = global::Modem.Properties.Resources.modem_part;
            this.ModemPartPicture.Location = new System.Drawing.Point(26, 203);
            this.ModemPartPicture.Name = "ModemPartPicture";
            this.ModemPartPicture.Size = new System.Drawing.Size(450, 356);
            this.ModemPartPicture.TabIndex = 23;
            this.ModemPartPicture.TabStop = false;
            // 
            // PigtailM1Picture
            // 
            this.PigtailM1Picture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PigtailM1Picture.Image = global::Modem.Properties.Resources.pigtail_ipex;
            this.PigtailM1Picture.Location = new System.Drawing.Point(295, 142);
            this.PigtailM1Picture.Name = "PigtailM1Picture";
            this.PigtailM1Picture.Size = new System.Drawing.Size(46, 116);
            this.PigtailM1Picture.TabIndex = 25;
            this.PigtailM1Picture.TabStop = false;
            this.PigtailM1Picture.Tag = "4";
            this.PigtailM1Picture.Visible = false;
            // 
            // PigtailM2Picture
            // 
            this.PigtailM2Picture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PigtailM2Picture.Image = global::Modem.Properties.Resources.pigtail_ipex;
            this.PigtailM2Picture.Location = new System.Drawing.Point(161, 142);
            this.PigtailM2Picture.Name = "PigtailM2Picture";
            this.PigtailM2Picture.Size = new System.Drawing.Size(46, 116);
            this.PigtailM2Picture.TabIndex = 26;
            this.PigtailM2Picture.TabStop = false;
            this.PigtailM2Picture.Tag = "8";
            this.PigtailM2Picture.Visible = false;
            // 
            // PigtailDGPicture
            // 
            this.PigtailDGPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PigtailDGPicture.Image = global::Modem.Properties.Resources.pigtail_ipex;
            this.PigtailDGPicture.Location = new System.Drawing.Point(45, 141);
            this.PigtailDGPicture.Name = "PigtailDGPicture";
            this.PigtailDGPicture.Size = new System.Drawing.Size(46, 116);
            this.PigtailDGPicture.TabIndex = 27;
            this.PigtailDGPicture.TabStop = false;
            this.PigtailDGPicture.Tag = "2";
            this.PigtailDGPicture.Visible = false;
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
            this.PageDescriptionTextBox.Size = new System.Drawing.Size(980, 65);
            this.PageDescriptionTextBox.TabIndex = 28;
            this.PageDescriptionTextBox.Text = "Данный раздел предназначен для настройки параметров подключаемых антенн, а именно" +
    ": какие разъёмы будут задействованы при получении и передаче информации по радио" +
    "каналу.";
            // 
            // SaveValuesButton
            // 
            this.SaveValuesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveValuesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(131)))));
            this.SaveValuesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(222)))), ((int)(((byte)(189)))));
            this.SaveValuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveValuesButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SaveValuesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.SaveValuesButton.Location = new System.Drawing.Point(765, 604);
            this.SaveValuesButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.SaveValuesButton.MaximumSize = new System.Drawing.Size(230, 51);
            this.SaveValuesButton.Name = "SaveValuesButton";
            this.SaveValuesButton.Size = new System.Drawing.Size(230, 51);
            this.SaveValuesButton.TabIndex = 40;
            this.SaveValuesButton.Text = "Сохранить изменения";
            this.SaveValuesButton.UseVisualStyleBackColor = false;
            this.SaveValuesButton.Click += new System.EventHandler(this.Button_Click);
            this.SaveValuesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SaveValuesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ResetValuesButton
            // 
            this.ResetValuesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetValuesButton.FlatAppearance.BorderSize = 0;
            this.ResetValuesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResetValuesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResetValuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetValuesButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResetValuesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ResetValuesButton.Location = new System.Drawing.Point(544, 611);
            this.ResetValuesButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ResetValuesButton.Name = "ResetValuesButton";
            this.ResetValuesButton.Size = new System.Drawing.Size(215, 36);
            this.ResetValuesButton.TabIndex = 41;
            this.ResetValuesButton.Text = "Сбросить изменения";
            this.ResetValuesButton.UseVisualStyleBackColor = false;
            this.ResetValuesButton.Click += new System.EventHandler(this.Button_Click);
            this.ResetValuesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ResetValuesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // AntennaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.ResetValuesButton);
            this.Controls.Add(this.SaveValuesButton);
            this.Controls.Add(this.PageDescriptionTextBox);
            this.Controls.Add(this.PigtailDGPicture);
            this.Controls.Add(this.PigtailM2Picture);
            this.Controls.Add(this.PigtailM1Picture);
            this.Controls.Add(this.PigtailMPicture);
            this.Controls.Add(this.ModeRFPanel);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.ModemPartPicture);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1020, 680);
            this.Name = "AntennaPage";
            this.Size = new System.Drawing.Size(1020, 680);
            this.Load += new System.EventHandler(this.Page_Load);
            this.ModeRFPanel.ResumeLayout(false);
            this.ModeRFPanel.PerformLayout();
            this.RFButtonsPanel.ResumeLayout(false);
            this.ModeRFTitlePanel.ResumeLayout(false);
            this.ModeRFTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PigtailMPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModemPartPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigtailM1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigtailM2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigtailDGPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.Panel ModeRFPanel;
        private Modem.Controls.BorderedPanel ModeRFTitlePanel;
        private System.Windows.Forms.Label RFModeTitleLabel;
        private System.Windows.Forms.PictureBox ModemPartPicture;
        private System.Windows.Forms.Panel RFButtonsPanel;
        private System.Windows.Forms.Button RFModeAllButton;
        private System.Windows.Forms.Button RFModeM2Button;
        private System.Windows.Forms.Button RFModeM1Button;
        private System.Windows.Forms.Button RFModeDGButton;
        private System.Windows.Forms.Button RFModeMButton;
        private System.Windows.Forms.Label RFModeDecriptionLabel;
        private System.Windows.Forms.PictureBox PigtailMPicture;
        private System.Windows.Forms.PictureBox PigtailM1Picture;
        private System.Windows.Forms.PictureBox PigtailM2Picture;
        private System.Windows.Forms.PictureBox PigtailDGPicture;
        private System.Windows.Forms.TextBox PageDescriptionTextBox;
        private System.Windows.Forms.Button SaveValuesButton;
        private System.Windows.Forms.Button ResetValuesButton;
    }
}
