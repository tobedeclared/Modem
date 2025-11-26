namespace Modem.Pages
{
    partial class GeneralPage
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
            this.PageDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.ManufacButton = new System.Windows.Forms.Button();
            this.ModemPicture = new System.Windows.Forms.PictureBox();
            this.SnLabel = new System.Windows.Forms.Label();
            this.ImeiLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacValueButton = new System.Windows.Forms.Button();
            this.ModelValueButton = new System.Windows.Forms.Button();
            this.ModelButton = new System.Windows.Forms.Button();
            this.SnValueButton = new System.Windows.Forms.Button();
            this.SnButton = new System.Windows.Forms.Button();
            this.FirmwareValueButton = new System.Windows.Forms.Button();
            this.FirmwareButton = new System.Windows.Forms.Button();
            this.ImeiValueButton = new System.Windows.Forms.Button();
            this.ImeiButton = new System.Windows.Forms.Button();
            this.SpecsPanel = new System.Windows.Forms.Panel();
            this.ImeiCopyButton = new System.Windows.Forms.Button();
            this.SnCopyButton = new System.Windows.Forms.Button();
            this.FirmwareCopyButton = new System.Windows.Forms.Button();
            this.ModelCopyButton = new System.Windows.Forms.Button();
            this.ManufacCopyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ModemPicture)).BeginInit();
            this.SpecsPanel.SuspendLayout();
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
            this.PageDescriptionTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.PageDescriptionTextBox.Multiline = true;
            this.PageDescriptionTextBox.Name = "PageDescriptionTextBox";
            this.PageDescriptionTextBox.Size = new System.Drawing.Size(980, 65);
            this.PageDescriptionTextBox.TabIndex = 30;
            this.PageDescriptionTextBox.Text = "Данный раздел предназначен для ознакомления с основными характеристиками вашего у" +
    "стройства (модема).";
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
            this.PageTitleLabel.Size = new System.Drawing.Size(364, 67);
            this.PageTitleLabel.TabIndex = 29;
            this.PageTitleLabel.Text = "Информация об устройстве";
            // 
            // ManufacButton
            // 
            this.ManufacButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ManufacButton.FlatAppearance.BorderSize = 0;
            this.ManufacButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ManufacButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ManufacButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManufacButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManufacButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ManufacButton.Location = new System.Drawing.Point(0, 0);
            this.ManufacButton.Margin = new System.Windows.Forms.Padding(0);
            this.ManufacButton.Name = "ManufacButton";
            this.ManufacButton.Size = new System.Drawing.Size(298, 40);
            this.ManufacButton.TabIndex = 31;
            this.ManufacButton.Text = "Производитель";
            this.ManufacButton.UseVisualStyleBackColor = false;
            // 
            // ModemPicture
            // 
            this.ModemPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModemPicture.BackgroundImage = global::Modem.Properties.Resources.modem;
            this.ModemPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ModemPicture.Location = new System.Drawing.Point(307, 121);
            this.ModemPicture.Name = "ModemPicture";
            this.ModemPicture.Size = new System.Drawing.Size(384, 228);
            this.ModemPicture.TabIndex = 32;
            this.ModemPicture.TabStop = false;
            // 
            // SnLabel
            // 
            this.SnLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SnLabel.AutoSize = true;
            this.SnLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SnLabel.Location = new System.Drawing.Point(359, 273);
            this.SnLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SnLabel.Name = "SnLabel";
            this.SnLabel.Size = new System.Drawing.Size(43, 23);
            this.SnLabel.TabIndex = 33;
            this.SnLabel.Text = "S/N:";
            // 
            // ImeiLabel
            // 
            this.ImeiLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImeiLabel.AutoSize = true;
            this.ImeiLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ImeiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ImeiLabel.Location = new System.Drawing.Point(355, 301);
            this.ImeiLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ImeiLabel.Name = "ImeiLabel";
            this.ImeiLabel.Size = new System.Drawing.Size(48, 23);
            this.ImeiLabel.TabIndex = 34;
            this.ImeiLabel.Text = "IMEI:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ModelLabel.Location = new System.Drawing.Point(355, 179);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(216, 28);
            this.ModelLabel.TabIndex = 35;
            this.ModelLabel.Text = "Получение данных...";
            // 
            // ManufacValueButton
            // 
            this.ManufacValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ManufacValueButton.FlatAppearance.BorderSize = 0;
            this.ManufacValueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ManufacValueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ManufacValueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManufacValueButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManufacValueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ManufacValueButton.Location = new System.Drawing.Point(298, 0);
            this.ManufacValueButton.Margin = new System.Windows.Forms.Padding(0);
            this.ManufacValueButton.Name = "ManufacValueButton";
            this.ManufacValueButton.Size = new System.Drawing.Size(449, 40);
            this.ManufacValueButton.TabIndex = 36;
            this.ManufacValueButton.Text = "Получение данных...";
            this.ManufacValueButton.UseVisualStyleBackColor = false;
            // 
            // ModelValueButton
            // 
            this.ModelValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ModelValueButton.FlatAppearance.BorderSize = 0;
            this.ModelValueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ModelValueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ModelValueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelValueButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ModelValueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ModelValueButton.Location = new System.Drawing.Point(298, 40);
            this.ModelValueButton.Margin = new System.Windows.Forms.Padding(0);
            this.ModelValueButton.Name = "ModelValueButton";
            this.ModelValueButton.Size = new System.Drawing.Size(449, 40);
            this.ModelValueButton.TabIndex = 38;
            this.ModelValueButton.Text = "Получение данных...";
            this.ModelValueButton.UseVisualStyleBackColor = false;
            // 
            // ModelButton
            // 
            this.ModelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ModelButton.FlatAppearance.BorderSize = 0;
            this.ModelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ModelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ModelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ModelButton.Location = new System.Drawing.Point(0, 40);
            this.ModelButton.Margin = new System.Windows.Forms.Padding(0);
            this.ModelButton.Name = "ModelButton";
            this.ModelButton.Size = new System.Drawing.Size(298, 40);
            this.ModelButton.TabIndex = 37;
            this.ModelButton.Text = "Модель";
            this.ModelButton.UseVisualStyleBackColor = false;
            // 
            // SnValueButton
            // 
            this.SnValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.SnValueButton.FlatAppearance.BorderSize = 0;
            this.SnValueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SnValueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SnValueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SnValueButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SnValueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.SnValueButton.Location = new System.Drawing.Point(298, 118);
            this.SnValueButton.Margin = new System.Windows.Forms.Padding(0);
            this.SnValueButton.Name = "SnValueButton";
            this.SnValueButton.Size = new System.Drawing.Size(449, 40);
            this.SnValueButton.TabIndex = 42;
            this.SnValueButton.Text = "Получение данных...";
            this.SnValueButton.UseVisualStyleBackColor = false;
            // 
            // SnButton
            // 
            this.SnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.SnButton.FlatAppearance.BorderSize = 0;
            this.SnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SnButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.SnButton.Location = new System.Drawing.Point(0, 118);
            this.SnButton.Margin = new System.Windows.Forms.Padding(0);
            this.SnButton.Name = "SnButton";
            this.SnButton.Size = new System.Drawing.Size(298, 40);
            this.SnButton.TabIndex = 41;
            this.SnButton.Text = "Cерийный номер";
            this.SnButton.UseVisualStyleBackColor = false;
            // 
            // FirmwareValueButton
            // 
            this.FirmwareValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.FirmwareValueButton.FlatAppearance.BorderSize = 0;
            this.FirmwareValueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FirmwareValueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FirmwareValueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirmwareValueButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FirmwareValueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.FirmwareValueButton.Location = new System.Drawing.Point(298, 80);
            this.FirmwareValueButton.Margin = new System.Windows.Forms.Padding(0);
            this.FirmwareValueButton.Name = "FirmwareValueButton";
            this.FirmwareValueButton.Size = new System.Drawing.Size(449, 40);
            this.FirmwareValueButton.TabIndex = 40;
            this.FirmwareValueButton.Text = "Получение данных...";
            this.FirmwareValueButton.UseVisualStyleBackColor = false;
            // 
            // FirmwareButton
            // 
            this.FirmwareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.FirmwareButton.FlatAppearance.BorderSize = 0;
            this.FirmwareButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FirmwareButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FirmwareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirmwareButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FirmwareButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.FirmwareButton.Location = new System.Drawing.Point(0, 80);
            this.FirmwareButton.Margin = new System.Windows.Forms.Padding(0);
            this.FirmwareButton.Name = "FirmwareButton";
            this.FirmwareButton.Size = new System.Drawing.Size(298, 40);
            this.FirmwareButton.TabIndex = 39;
            this.FirmwareButton.Text = "Версия ПО";
            this.FirmwareButton.UseVisualStyleBackColor = false;
            // 
            // ImeiValueButton
            // 
            this.ImeiValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ImeiValueButton.FlatAppearance.BorderSize = 0;
            this.ImeiValueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ImeiValueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ImeiValueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImeiValueButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ImeiValueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ImeiValueButton.Location = new System.Drawing.Point(298, 157);
            this.ImeiValueButton.Margin = new System.Windows.Forms.Padding(0);
            this.ImeiValueButton.Name = "ImeiValueButton";
            this.ImeiValueButton.Size = new System.Drawing.Size(449, 40);
            this.ImeiValueButton.TabIndex = 44;
            this.ImeiValueButton.Text = "Получение данных...";
            this.ImeiValueButton.UseVisualStyleBackColor = false;
            // 
            // ImeiButton
            // 
            this.ImeiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ImeiButton.FlatAppearance.BorderSize = 0;
            this.ImeiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ImeiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ImeiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImeiButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ImeiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ImeiButton.Location = new System.Drawing.Point(0, 157);
            this.ImeiButton.Margin = new System.Windows.Forms.Padding(0);
            this.ImeiButton.Name = "ImeiButton";
            this.ImeiButton.Size = new System.Drawing.Size(298, 40);
            this.ImeiButton.TabIndex = 43;
            this.ImeiButton.Text = "IMEI";
            this.ImeiButton.UseVisualStyleBackColor = false;
            // 
            // SpecsPanel
            // 
            this.SpecsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpecsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpecsPanel.Controls.Add(this.FirmwareValueButton);
            this.SpecsPanel.Controls.Add(this.FirmwareButton);
            this.SpecsPanel.Controls.Add(this.ModelValueButton);
            this.SpecsPanel.Controls.Add(this.ModelButton);
            this.SpecsPanel.Controls.Add(this.SnButton);
            this.SpecsPanel.Controls.Add(this.SnValueButton);
            this.SpecsPanel.Controls.Add(this.ImeiValueButton);
            this.SpecsPanel.Controls.Add(this.ImeiButton);
            this.SpecsPanel.Controls.Add(this.ManufacButton);
            this.SpecsPanel.Controls.Add(this.ManufacValueButton);
            this.SpecsPanel.Location = new System.Drawing.Point(110, 373);
            this.SpecsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SpecsPanel.Name = "SpecsPanel";
            this.SpecsPanel.Size = new System.Drawing.Size(749, 200);
            this.SpecsPanel.TabIndex = 45;
            // 
            // ImeiCopyButton
            // 
            this.ImeiCopyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImeiCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImeiCopyButton.FlatAppearance.BorderSize = 0;
            this.ImeiCopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ImeiCopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ImeiCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImeiCopyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ImeiCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ImeiCopyButton.Image = global::Modem.Properties.Resources.copyBtn;
            this.ImeiCopyButton.Location = new System.Drawing.Point(862, 530);
            this.ImeiCopyButton.Name = "ImeiCopyButton";
            this.ImeiCopyButton.Size = new System.Drawing.Size(41, 42);
            this.ImeiCopyButton.TabIndex = 4;
            this.ImeiCopyButton.UseVisualStyleBackColor = false;
            this.ImeiCopyButton.Click += new System.EventHandler(this.Button_Click);
            this.ImeiCopyButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ImeiCopyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SnCopyButton
            // 
            this.SnCopyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SnCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SnCopyButton.FlatAppearance.BorderSize = 0;
            this.SnCopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SnCopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SnCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SnCopyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SnCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.SnCopyButton.Image = global::Modem.Properties.Resources.copyBtn;
            this.SnCopyButton.Location = new System.Drawing.Point(861, 492);
            this.SnCopyButton.Name = "SnCopyButton";
            this.SnCopyButton.Size = new System.Drawing.Size(41, 40);
            this.SnCopyButton.TabIndex = 3;
            this.SnCopyButton.UseVisualStyleBackColor = false;
            this.SnCopyButton.Click += new System.EventHandler(this.Button_Click);
            this.SnCopyButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SnCopyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // FirmwareCopyButton
            // 
            this.FirmwareCopyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirmwareCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirmwareCopyButton.FlatAppearance.BorderSize = 0;
            this.FirmwareCopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FirmwareCopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FirmwareCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirmwareCopyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FirmwareCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.FirmwareCopyButton.Image = global::Modem.Properties.Resources.copyBtn;
            this.FirmwareCopyButton.Location = new System.Drawing.Point(861, 453);
            this.FirmwareCopyButton.Name = "FirmwareCopyButton";
            this.FirmwareCopyButton.Size = new System.Drawing.Size(41, 42);
            this.FirmwareCopyButton.TabIndex = 2;
            this.FirmwareCopyButton.UseVisualStyleBackColor = false;
            this.FirmwareCopyButton.Click += new System.EventHandler(this.Button_Click);
            this.FirmwareCopyButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.FirmwareCopyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ModelCopyButton
            // 
            this.ModelCopyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModelCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModelCopyButton.FlatAppearance.BorderSize = 0;
            this.ModelCopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ModelCopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ModelCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelCopyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ModelCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ModelCopyButton.Image = global::Modem.Properties.Resources.copyBtn;
            this.ModelCopyButton.Location = new System.Drawing.Point(862, 413);
            this.ModelCopyButton.Name = "ModelCopyButton";
            this.ModelCopyButton.Size = new System.Drawing.Size(41, 42);
            this.ModelCopyButton.TabIndex = 1;
            this.ModelCopyButton.UseVisualStyleBackColor = false;
            this.ModelCopyButton.Click += new System.EventHandler(this.Button_Click);
            this.ModelCopyButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ModelCopyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ManufacCopyButton
            // 
            this.ManufacCopyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManufacCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManufacCopyButton.FlatAppearance.BorderSize = 0;
            this.ManufacCopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ManufacCopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ManufacCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManufacCopyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManufacCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ManufacCopyButton.Image = global::Modem.Properties.Resources.copyBtn;
            this.ManufacCopyButton.Location = new System.Drawing.Point(862, 373);
            this.ManufacCopyButton.Name = "ManufacCopyButton";
            this.ManufacCopyButton.Size = new System.Drawing.Size(41, 42);
            this.ManufacCopyButton.TabIndex = 0;
            this.ManufacCopyButton.UseVisualStyleBackColor = false;
            this.ManufacCopyButton.Click += new System.EventHandler(this.Button_Click);
            this.ManufacCopyButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ManufacCopyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // GeneralPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.ManufacCopyButton);
            this.Controls.Add(this.ModelCopyButton);
            this.Controls.Add(this.FirmwareCopyButton);
            this.Controls.Add(this.SnCopyButton);
            this.Controls.Add(this.ImeiCopyButton);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ImeiLabel);
            this.Controls.Add(this.SnLabel);
            this.Controls.Add(this.ModemPicture);
            this.Controls.Add(this.PageDescriptionTextBox);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.SpecsPanel);
            this.MinimumSize = new System.Drawing.Size(1020, 680);
            this.Name = "GeneralPage";
            this.Size = new System.Drawing.Size(1020, 680);
            this.Load += new System.EventHandler(this.Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModemPicture)).EndInit();
            this.SpecsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PageDescriptionTextBox;
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.Button ManufacButton;
        private System.Windows.Forms.PictureBox ModemPicture;
        private System.Windows.Forms.Label SnLabel;
        private System.Windows.Forms.Label ImeiLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button ManufacValueButton;
        private System.Windows.Forms.Button ModelValueButton;
        private System.Windows.Forms.Button ModelButton;
        private System.Windows.Forms.Button SnValueButton;
        private System.Windows.Forms.Button SnButton;
        private System.Windows.Forms.Button FirmwareValueButton;
        private System.Windows.Forms.Button FirmwareButton;
        private System.Windows.Forms.Button ImeiValueButton;
        private System.Windows.Forms.Button ImeiButton;
        private System.Windows.Forms.Panel SpecsPanel;
        private System.Windows.Forms.Button ImeiCopyButton;
        private System.Windows.Forms.Button SnCopyButton;
        private System.Windows.Forms.Button FirmwareCopyButton;
        private System.Windows.Forms.Button ModelCopyButton;
        private System.Windows.Forms.Button ManufacCopyButton;
    }
}
