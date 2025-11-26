namespace Modem.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeadAndWorkContainer = new System.Windows.Forms.SplitContainer();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HideButton = new System.Windows.Forms.Button();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MenuAndWorkContainer = new System.Windows.Forms.SplitContainer();
            this.MenuPanel = new Modem.Controls.BorderedPanel();
            this.SettingsButtonPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ImeiButtonPanel = new System.Windows.Forms.Panel();
            this.ImeiButton = new System.Windows.Forms.Button();
            this.AntennaButtonPanel = new System.Windows.Forms.Panel();
            this.AntennaButton = new System.Windows.Forms.Button();
            this.FreqButtonPanel = new System.Windows.Forms.Panel();
            this.FreqButton = new System.Windows.Forms.Button();
            this.OperatorButtonPanel = new System.Windows.Forms.Panel();
            this.OperatorButton = new System.Windows.Forms.Button();
            this.HomeButtonPanel = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.MenuAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HeadAndWorkContainer)).BeginInit();
            this.HeadAndWorkContainer.Panel1.SuspendLayout();
            this.HeadAndWorkContainer.Panel2.SuspendLayout();
            this.HeadAndWorkContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuAndWorkContainer)).BeginInit();
            this.MenuAndWorkContainer.Panel1.SuspendLayout();
            this.MenuAndWorkContainer.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SettingsButtonPanel.SuspendLayout();
            this.ImeiButtonPanel.SuspendLayout();
            this.AntennaButtonPanel.SuspendLayout();
            this.FreqButtonPanel.SuspendLayout();
            this.OperatorButtonPanel.SuspendLayout();
            this.HomeButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadAndWorkContainer
            // 
            this.HeadAndWorkContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeadAndWorkContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.HeadAndWorkContainer.IsSplitterFixed = true;
            this.HeadAndWorkContainer.Location = new System.Drawing.Point(0, 0);
            this.HeadAndWorkContainer.Name = "HeadAndWorkContainer";
            this.HeadAndWorkContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HeadAndWorkContainer.Panel1
            // 
            this.HeadAndWorkContainer.Panel1.BackColor = System.Drawing.Color.Black;
            this.HeadAndWorkContainer.Panel1.Controls.Add(this.TitleLabel);
            this.HeadAndWorkContainer.Panel1.Controls.Add(this.HideButton);
            this.HeadAndWorkContainer.Panel1.Controls.Add(this.MaximizeButton);
            this.HeadAndWorkContainer.Panel1.Controls.Add(this.ExitButton);
            this.HeadAndWorkContainer.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.HeadAndWorkContainer.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // HeadAndWorkContainer.Panel2
            // 
            this.HeadAndWorkContainer.Panel2.Controls.Add(this.MenuAndWorkContainer);
            this.HeadAndWorkContainer.Size = new System.Drawing.Size(1280, 720);
            this.HeadAndWorkContainer.SplitterDistance = 40;
            this.HeadAndWorkContainer.SplitterWidth = 1;
            this.HeadAndWorkContainer.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(6, 6, 0, 0);
            this.TitleLabel.Size = new System.Drawing.Size(321, 29);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Центр управления модемами Fibocom";
            // 
            // HideButton
            // 
            this.HideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HideButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Image = global::Modem.Properties.Resources.hideBtn;
            this.HideButton.Location = new System.Drawing.Point(1130, 0);
            this.HideButton.Margin = new System.Windows.Forms.Padding(0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(50, 40);
            this.HideButton.TabIndex = 3;
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.Button_Click);
            this.HideButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.HideButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.Image")));
            this.MaximizeButton.Location = new System.Drawing.Point(1180, 0);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(50, 40);
            this.MaximizeButton.TabIndex = 2;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.Button_Click);
            this.MaximizeButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.MaximizeButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = global::Modem.Properties.Resources.closeBtn;
            this.ExitButton.Location = new System.Drawing.Point(1230, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 40);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Button_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // MenuAndWorkContainer
            // 
            this.MenuAndWorkContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuAndWorkContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MenuAndWorkContainer.IsSplitterFixed = true;
            this.MenuAndWorkContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuAndWorkContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MenuAndWorkContainer.Name = "MenuAndWorkContainer";
            // 
            // MenuAndWorkContainer.Panel1
            // 
            this.MenuAndWorkContainer.Panel1.Controls.Add(this.MenuPanel);
            this.MenuAndWorkContainer.Size = new System.Drawing.Size(1280, 679);
            this.MenuAndWorkContainer.SplitterDistance = 260;
            this.MenuAndWorkContainer.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.MenuPanel.BorderSide = Modem.Controls.BorderSide.Right;
            this.MenuPanel.BorderWidth = 1;
            this.MenuPanel.Controls.Add(this.SettingsButtonPanel);
            this.MenuPanel.Controls.Add(this.ImeiButtonPanel);
            this.MenuPanel.Controls.Add(this.AntennaButtonPanel);
            this.MenuPanel.Controls.Add(this.FreqButtonPanel);
            this.MenuPanel.Controls.Add(this.OperatorButtonPanel);
            this.MenuPanel.Controls.Add(this.HomeButtonPanel);
            this.MenuPanel.Controls.Add(this.MenuButton);
            this.MenuPanel.Controls.Add(this.LogoPictureBox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 25);
            this.MenuPanel.Size = new System.Drawing.Size(260, 679);
            this.MenuPanel.TabIndex = 0;
            // 
            // SettingsButtonPanel
            // 
            this.SettingsButtonPanel.Controls.Add(this.SettingsButton);
            this.SettingsButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButtonPanel.Location = new System.Drawing.Point(8, 604);
            this.SettingsButtonPanel.Name = "SettingsButtonPanel";
            this.SettingsButtonPanel.Size = new System.Drawing.Size(244, 50);
            this.SettingsButtonPanel.TabIndex = 9;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.SettingsButton.Image = global::Modem.Properties.Resources.setBtn;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 0);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.SettingsButton.Size = new System.Drawing.Size(244, 50);
            this.SettingsButton.TabIndex = 10;
            this.SettingsButton.Text = "   Настройки";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.Button_Click);
            this.SettingsButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SettingsButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ImeiButtonPanel
            // 
            this.ImeiButtonPanel.Controls.Add(this.ImeiButton);
            this.ImeiButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImeiButtonPanel.Location = new System.Drawing.Point(8, 387);
            this.ImeiButtonPanel.Name = "ImeiButtonPanel";
            this.ImeiButtonPanel.Size = new System.Drawing.Size(244, 50);
            this.ImeiButtonPanel.TabIndex = 8;
            // 
            // ImeiButton
            // 
            this.ImeiButton.FlatAppearance.BorderSize = 0;
            this.ImeiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImeiButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImeiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.ImeiButton.Image = global::Modem.Properties.Resources.imeiBtn;
            this.ImeiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImeiButton.Location = new System.Drawing.Point(0, 0);
            this.ImeiButton.Margin = new System.Windows.Forms.Padding(0);
            this.ImeiButton.Name = "ImeiButton";
            this.ImeiButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ImeiButton.Size = new System.Drawing.Size(244, 50);
            this.ImeiButton.TabIndex = 9;
            this.ImeiButton.Text = "   IMEI";
            this.ImeiButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImeiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImeiButton.UseVisualStyleBackColor = true;
            this.ImeiButton.Click += new System.EventHandler(this.Button_Click);
            this.ImeiButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ImeiButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // AntennaButtonPanel
            // 
            this.AntennaButtonPanel.Controls.Add(this.AntennaButton);
            this.AntennaButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AntennaButtonPanel.Location = new System.Drawing.Point(8, 337);
            this.AntennaButtonPanel.Name = "AntennaButtonPanel";
            this.AntennaButtonPanel.Size = new System.Drawing.Size(244, 50);
            this.AntennaButtonPanel.TabIndex = 7;
            // 
            // AntennaButton
            // 
            this.AntennaButton.FlatAppearance.BorderSize = 0;
            this.AntennaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AntennaButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AntennaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.AntennaButton.Image = global::Modem.Properties.Resources.antBtn;
            this.AntennaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AntennaButton.Location = new System.Drawing.Point(0, 0);
            this.AntennaButton.Margin = new System.Windows.Forms.Padding(0);
            this.AntennaButton.Name = "AntennaButton";
            this.AntennaButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.AntennaButton.Size = new System.Drawing.Size(244, 50);
            this.AntennaButton.TabIndex = 8;
            this.AntennaButton.Text = "   Антенна";
            this.AntennaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AntennaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AntennaButton.UseVisualStyleBackColor = true;
            this.AntennaButton.Click += new System.EventHandler(this.Button_Click);
            this.AntennaButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.AntennaButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // FreqButtonPanel
            // 
            this.FreqButtonPanel.Controls.Add(this.FreqButton);
            this.FreqButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FreqButtonPanel.Location = new System.Drawing.Point(8, 287);
            this.FreqButtonPanel.Name = "FreqButtonPanel";
            this.FreqButtonPanel.Size = new System.Drawing.Size(244, 50);
            this.FreqButtonPanel.TabIndex = 1;
            // 
            // FreqButton
            // 
            this.FreqButton.FlatAppearance.BorderSize = 0;
            this.FreqButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FreqButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreqButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.FreqButton.Image = global::Modem.Properties.Resources.freqBtn;
            this.FreqButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FreqButton.Location = new System.Drawing.Point(0, 0);
            this.FreqButton.Margin = new System.Windows.Forms.Padding(0);
            this.FreqButton.Name = "FreqButton";
            this.FreqButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.FreqButton.Size = new System.Drawing.Size(244, 50);
            this.FreqButton.TabIndex = 7;
            this.FreqButton.Text = "   Частотный диапазон";
            this.FreqButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FreqButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FreqButton.UseVisualStyleBackColor = true;
            this.FreqButton.Click += new System.EventHandler(this.Button_Click);
            this.FreqButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.FreqButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // OperatorButtonPanel
            // 
            this.OperatorButtonPanel.Controls.Add(this.OperatorButton);
            this.OperatorButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OperatorButtonPanel.Location = new System.Drawing.Point(8, 237);
            this.OperatorButtonPanel.Name = "OperatorButtonPanel";
            this.OperatorButtonPanel.Size = new System.Drawing.Size(244, 50);
            this.OperatorButtonPanel.TabIndex = 1;
            // 
            // OperatorButton
            // 
            this.OperatorButton.FlatAppearance.BorderSize = 0;
            this.OperatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OperatorButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperatorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.OperatorButton.Image = global::Modem.Properties.Resources.opBtn;
            this.OperatorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OperatorButton.Location = new System.Drawing.Point(0, 0);
            this.OperatorButton.Margin = new System.Windows.Forms.Padding(0);
            this.OperatorButton.Name = "OperatorButton";
            this.OperatorButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.OperatorButton.Size = new System.Drawing.Size(244, 50);
            this.OperatorButton.TabIndex = 6;
            this.OperatorButton.Text = "   Сотовый оператор";
            this.OperatorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OperatorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OperatorButton.UseVisualStyleBackColor = true;
            this.OperatorButton.Click += new System.EventHandler(this.Button_Click);
            this.OperatorButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.OperatorButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // HomeButtonPanel
            // 
            this.HomeButtonPanel.Controls.Add(this.HomeButton);
            this.HomeButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButtonPanel.Location = new System.Drawing.Point(8, 187);
            this.HomeButtonPanel.Name = "HomeButtonPanel";
            this.HomeButtonPanel.Size = new System.Drawing.Size(244, 50);
            this.HomeButtonPanel.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.HomeButton.Image = global::Modem.Properties.Resources.homeBtn;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(244, 50);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.Text = "   Общие сведения";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.Button_Click);
            this.HomeButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.HomeButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // MenuButton
            // 
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.MenuButton.Image = global::Modem.Properties.Resources.menuBtn;
            this.MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuButton.Location = new System.Drawing.Point(8, 137);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.MenuButton.Size = new System.Drawing.Size(244, 50);
            this.MenuButton.TabIndex = 4;
            this.MenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.Button_Click);
            this.MenuButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.MenuButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::Modem.Properties.Resources.logo;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPictureBox.Location = new System.Drawing.Point(8, 8);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(244, 129);
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // MenuAnimation
            // 
            this.MenuAnimation.Interval = 16;
            this.MenuAnimation.Tick += new System.EventHandler(this.MenuAnimation_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.HeadAndWorkContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Центр управления модемами Fibocom";
            this.Load += new System.EventHandler(this.Form_Load);
            this.HeadAndWorkContainer.Panel1.ResumeLayout(false);
            this.HeadAndWorkContainer.Panel1.PerformLayout();
            this.HeadAndWorkContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeadAndWorkContainer)).EndInit();
            this.HeadAndWorkContainer.ResumeLayout(false);
            this.MenuAndWorkContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuAndWorkContainer)).EndInit();
            this.MenuAndWorkContainer.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.SettingsButtonPanel.ResumeLayout(false);
            this.ImeiButtonPanel.ResumeLayout(false);
            this.AntennaButtonPanel.ResumeLayout(false);
            this.FreqButtonPanel.ResumeLayout(false);
            this.OperatorButtonPanel.ResumeLayout(false);
            this.HomeButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer HeadAndWorkContainer;
        private System.Windows.Forms.SplitContainer MenuAndWorkContainer;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ImeiButton;
        private System.Windows.Forms.Button AntennaButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button FreqButton;
        private System.Windows.Forms.Button OperatorButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Timer MenuAnimation;
        private System.Windows.Forms.Panel HomeButtonPanel;
        private System.Windows.Forms.Panel SettingsButtonPanel;
        private System.Windows.Forms.Panel ImeiButtonPanel;
        private System.Windows.Forms.Panel FreqButtonPanel;
        private System.Windows.Forms.Panel OperatorButtonPanel;
        private System.Windows.Forms.Panel AntennaButtonPanel;
        private Modem.Controls.BorderedPanel MenuPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}