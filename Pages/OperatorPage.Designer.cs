namespace Modem.Pages
{
    partial class OperatorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorPage));
            this.PageDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.RatLabel = new System.Windows.Forms.Label();
            this.ApnTextBox = new System.Windows.Forms.TextBox();
            this.ApnLabel = new System.Windows.Forms.Label();
            this.PlmnLabel = new System.Windows.Forms.Label();
            this.PlmnTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.AuthLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.Rat4GButton = new System.Windows.Forms.Button();
            this.Rat5GButton = new System.Windows.Forms.Button();
            this.AuthPapButton = new System.Windows.Forms.Button();
            this.AuthChapButton = new System.Windows.Forms.Button();
            this.AuthNoButton = new System.Windows.Forms.Button();
            this.RatPanel = new System.Windows.Forms.Panel();
            this.ApnPanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.SaveValuesButton = new System.Windows.Forms.Button();
            this.ResetValuesButton = new System.Windows.Forms.Button();
            this.AnnotationTextBox = new System.Windows.Forms.TextBox();
            this.RatPanel.SuspendLayout();
            this.ApnPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
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
            this.PageDescriptionTextBox.Size = new System.Drawing.Size(980, 60);
            this.PageDescriptionTextBox.TabIndex = 11;
            this.PageDescriptionTextBox.TabStop = false;
            this.PageDescriptionTextBox.Text = "Данный раздел предназначен для настройки параметров подключения к сети мобильного" +
    " (сотового) оператора. При неверной настройке параметров могут возникуть проблем" +
    "ы с подключением к сети.";
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
            this.PageTitleLabel.Size = new System.Drawing.Size(457, 67);
            this.PageTitleLabel.TabIndex = 12;
            this.PageTitleLabel.Text = "Конфигурация сотового оператора";
            // 
            // RatLabel
            // 
            this.RatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RatLabel.AutoSize = true;
            this.RatLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RatLabel.Location = new System.Drawing.Point(83, 23);
            this.RatLabel.Name = "RatLabel";
            this.RatLabel.Size = new System.Drawing.Size(90, 28);
            this.RatLabel.TabIndex = 0;
            this.RatLabel.Text = "Тип сети";
            // 
            // ApnTextBox
            // 
            this.ApnTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.ApnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApnTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ApnTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ApnTextBox.Location = new System.Drawing.Point(216, 17);
            this.ApnTextBox.Name = "ApnTextBox";
            this.ApnTextBox.Size = new System.Drawing.Size(206, 34);
            this.ApnTextBox.TabIndex = 35;
            this.ApnTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ApnLabel
            // 
            this.ApnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApnLabel.AutoSize = true;
            this.ApnLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ApnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ApnLabel.Location = new System.Drawing.Point(11, 20);
            this.ApnLabel.Name = "ApnLabel";
            this.ApnLabel.Size = new System.Drawing.Size(198, 28);
            this.ApnLabel.TabIndex = 36;
            this.ApnLabel.Text = "Точка доступа (APN)";
            // 
            // PlmnLabel
            // 
            this.PlmnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlmnLabel.AutoSize = true;
            this.PlmnLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlmnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PlmnLabel.Location = new System.Drawing.Point(96, 73);
            this.PlmnLabel.Name = "PlmnLabel";
            this.PlmnLabel.Size = new System.Drawing.Size(113, 28);
            this.PlmnLabel.TabIndex = 38;
            this.PlmnLabel.Text = "PLMN-код¹";
            // 
            // PlmnTextBox
            // 
            this.PlmnTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.PlmnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlmnTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlmnTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PlmnTextBox.Location = new System.Drawing.Point(216, 70);
            this.PlmnTextBox.MaxLength = 5;
            this.PlmnTextBox.Name = "PlmnTextBox";
            this.PlmnTextBox.Size = new System.Drawing.Size(206, 34);
            this.PlmnTextBox.TabIndex = 36;
            this.PlmnTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.PlmnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlmnTextBox_KeyPress);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LoginLabel.Location = new System.Drawing.Point(49, 95);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(182, 28);
            this.LoginLabel.TabIndex = 44;
            this.LoginLabel.Text = "Имя пользователя";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LoginTextBox.Location = new System.Drawing.Point(237, 92);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(265, 34);
            this.LoginTextBox.TabIndex = 37;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // AuthLabel
            // 
            this.AuthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AuthLabel.AutoSize = true;
            this.AuthLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AuthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AuthLabel.Location = new System.Drawing.Point(21, 32);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(210, 28);
            this.AuthLabel.TabIndex = 45;
            this.AuthLabel.Text = "Тип аутентификации²";
            // 
            // PassLabel
            // 
            this.PassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PassLabel.Location = new System.Drawing.Point(150, 152);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(81, 28);
            this.PassLabel.TabIndex = 48;
            this.PassLabel.Text = "Пароль";
            // 
            // PassTextBox
            // 
            this.PassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.PassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PassTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PassTextBox.Location = new System.Drawing.Point(237, 149);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(265, 34);
            this.PassTextBox.TabIndex = 38;
            this.PassTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Rat4GButton
            // 
            this.Rat4GButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rat4GButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Rat4GButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.Rat4GButton.Location = new System.Drawing.Point(179, 18);
            this.Rat4GButton.Name = "Rat4GButton";
            this.Rat4GButton.Size = new System.Drawing.Size(81, 39);
            this.Rat4GButton.TabIndex = 2;
            this.Rat4GButton.TabStop = false;
            this.Rat4GButton.Tag = "2";
            this.Rat4GButton.Text = "4G";
            this.Rat4GButton.UseVisualStyleBackColor = true;
            this.Rat4GButton.Click += new System.EventHandler(this.Button_Click);
            this.Rat4GButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Rat4GButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Rat5GButton
            // 
            this.Rat5GButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rat5GButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Rat5GButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.Rat5GButton.Location = new System.Drawing.Point(266, 18);
            this.Rat5GButton.Name = "Rat5GButton";
            this.Rat5GButton.Size = new System.Drawing.Size(81, 39);
            this.Rat5GButton.TabIndex = 3;
            this.Rat5GButton.TabStop = false;
            this.Rat5GButton.Tag = "14";
            this.Rat5GButton.Text = "5G";
            this.Rat5GButton.UseVisualStyleBackColor = true;
            this.Rat5GButton.Click += new System.EventHandler(this.Button_Click);
            this.Rat5GButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Rat5GButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // AuthPapButton
            // 
            this.AuthPapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthPapButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AuthPapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.AuthPapButton.Location = new System.Drawing.Point(421, 27);
            this.AuthPapButton.Name = "AuthPapButton";
            this.AuthPapButton.Size = new System.Drawing.Size(81, 39);
            this.AuthPapButton.TabIndex = 6;
            this.AuthPapButton.TabStop = false;
            this.AuthPapButton.Tag = "2";
            this.AuthPapButton.Text = "PAP";
            this.AuthPapButton.UseVisualStyleBackColor = true;
            this.AuthPapButton.Click += new System.EventHandler(this.Button_Click);
            this.AuthPapButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.AuthPapButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // AuthChapButton
            // 
            this.AuthChapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthChapButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AuthChapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.AuthChapButton.Location = new System.Drawing.Point(329, 27);
            this.AuthChapButton.Name = "AuthChapButton";
            this.AuthChapButton.Size = new System.Drawing.Size(81, 39);
            this.AuthChapButton.TabIndex = 5;
            this.AuthChapButton.TabStop = false;
            this.AuthChapButton.Tag = "1";
            this.AuthChapButton.Text = "CHAP";
            this.AuthChapButton.UseVisualStyleBackColor = true;
            this.AuthChapButton.Click += new System.EventHandler(this.Button_Click);
            this.AuthChapButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.AuthChapButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // AuthNoButton
            // 
            this.AuthNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthNoButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AuthNoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.AuthNoButton.Location = new System.Drawing.Point(237, 27);
            this.AuthNoButton.Name = "AuthNoButton";
            this.AuthNoButton.Size = new System.Drawing.Size(81, 39);
            this.AuthNoButton.TabIndex = 4;
            this.AuthNoButton.TabStop = false;
            this.AuthNoButton.Tag = "0";
            this.AuthNoButton.Text = "Нет";
            this.AuthNoButton.UseVisualStyleBackColor = true;
            this.AuthNoButton.Click += new System.EventHandler(this.Button_Click);
            this.AuthNoButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.AuthNoButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // RatPanel
            // 
            this.RatPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatPanel.Controls.Add(this.Rat5GButton);
            this.RatPanel.Controls.Add(this.Rat4GButton);
            this.RatPanel.Controls.Add(this.RatLabel);
            this.RatPanel.Location = new System.Drawing.Point(15, 141);
            this.RatPanel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.RatPanel.Name = "RatPanel";
            this.RatPanel.Size = new System.Drawing.Size(437, 75);
            this.RatPanel.TabIndex = 56;
            // 
            // ApnPanel
            // 
            this.ApnPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ApnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApnPanel.Controls.Add(this.ApnTextBox);
            this.ApnPanel.Controls.Add(this.ApnLabel);
            this.ApnPanel.Controls.Add(this.PlmnTextBox);
            this.ApnPanel.Controls.Add(this.PlmnLabel);
            this.ApnPanel.Location = new System.Drawing.Point(15, 222);
            this.ApnPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.ApnPanel.Name = "ApnPanel";
            this.ApnPanel.Size = new System.Drawing.Size(437, 126);
            this.ApnPanel.TabIndex = 57;
            // 
            // UserPanel
            // 
            this.UserPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPanel.Controls.Add(this.AuthPapButton);
            this.UserPanel.Controls.Add(this.LoginTextBox);
            this.UserPanel.Controls.Add(this.AuthChapButton);
            this.UserPanel.Controls.Add(this.LoginLabel);
            this.UserPanel.Controls.Add(this.AuthNoButton);
            this.UserPanel.Controls.Add(this.AuthLabel);
            this.UserPanel.Controls.Add(this.PassLabel);
            this.UserPanel.Controls.Add(this.PassTextBox);
            this.UserPanel.Location = new System.Drawing.Point(458, 141);
            this.UserPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(537, 207);
            this.UserPanel.TabIndex = 58;
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
            this.SaveValuesButton.TabIndex = 7;
            this.SaveValuesButton.TabStop = false;
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
            this.ResetValuesButton.TabIndex = 8;
            this.ResetValuesButton.TabStop = false;
            this.ResetValuesButton.Text = "Сбросить изменения";
            this.ResetValuesButton.UseVisualStyleBackColor = false;
            this.ResetValuesButton.Click += new System.EventHandler(this.Button_Click);
            this.ResetValuesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ResetValuesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // AnnotationTextBox
            // 
            this.AnnotationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AnnotationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.AnnotationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnnotationTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnnotationTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.AnnotationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AnnotationTextBox.Location = new System.Drawing.Point(15, 353);
            this.AnnotationTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.AnnotationTextBox.Multiline = true;
            this.AnnotationTextBox.Name = "AnnotationTextBox";
            this.AnnotationTextBox.Size = new System.Drawing.Size(980, 60);
            this.AnnotationTextBox.TabIndex = 10;
            this.AnnotationTextBox.TabStop = false;
            this.AnnotationTextBox.Text = resources.GetString("AnnotationTextBox.Text");
            // 
            // OperatorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.AnnotationTextBox);
            this.Controls.Add(this.SaveValuesButton);
            this.Controls.Add(this.ResetValuesButton);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.PageDescriptionTextBox);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.ApnPanel);
            this.Controls.Add(this.RatPanel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1020, 680);
            this.Name = "OperatorPage";
            this.Size = new System.Drawing.Size(1020, 680);
            this.Load += new System.EventHandler(this.Page_Load);
            this.RatPanel.ResumeLayout(false);
            this.RatPanel.PerformLayout();
            this.ApnPanel.ResumeLayout(false);
            this.ApnPanel.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PageDescriptionTextBox;
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.Label RatLabel;
        private System.Windows.Forms.TextBox ApnTextBox;
        private System.Windows.Forms.Label ApnLabel;
        private System.Windows.Forms.Label PlmnLabel;
        private System.Windows.Forms.TextBox PlmnTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label AuthLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button Rat4GButton;
        private System.Windows.Forms.Button Rat5GButton;
        private System.Windows.Forms.Button AuthPapButton;
        private System.Windows.Forms.Button AuthChapButton;
        private System.Windows.Forms.Button AuthNoButton;
        private System.Windows.Forms.Panel RatPanel;
        private System.Windows.Forms.Panel ApnPanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button SaveValuesButton;
        private System.Windows.Forms.Button ResetValuesButton;
        private System.Windows.Forms.TextBox AnnotationTextBox;
    }
}
