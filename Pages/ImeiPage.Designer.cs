namespace Modem.Pages
{
    partial class ImeiPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImeiPage));
            this.PageDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.ImeiValueLabel = new System.Windows.Forms.Label();
            this.MethodDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ImeiValueTextBox = new System.Windows.Forms.TextBox();
            this.SaveValuesButton = new System.Windows.Forms.Button();
            this.ResetValuesButton = new System.Windows.Forms.Button();
            this.Method2Panel = new System.Windows.Forms.Panel();
            this.Method1Panel = new System.Windows.Forms.Panel();
            this.MaskButton = new System.Windows.Forms.Button();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ResultModemImeiLabel = new System.Windows.Forms.Label();
            this.ResultImeiLabel = new System.Windows.Forms.Label();
            this.AnnotationTextBox = new System.Windows.Forms.TextBox();
            this.Method2Panel.SuspendLayout();
            this.Method1Panel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
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
            this.PageDescriptionTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.PageDescriptionTextBox.Multiline = true;
            this.PageDescriptionTextBox.Name = "PageDescriptionTextBox";
            this.PageDescriptionTextBox.Size = new System.Drawing.Size(980, 60);
            this.PageDescriptionTextBox.TabIndex = 21;
            this.PageDescriptionTextBox.TabStop = false;
            this.PageDescriptionTextBox.Text = "Данный раздел предназначен для изменения международного идентификатора мобильного" +
    " оборудования (IMEI) вашего модема.";
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
            this.PageTitleLabel.Size = new System.Drawing.Size(69, 67);
            this.PageTitleLabel.TabIndex = 23;
            this.PageTitleLabel.Text = "IMEI";
            // 
            // ImeiValueLabel
            // 
            this.ImeiValueLabel.AutoSize = true;
            this.ImeiValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ImeiValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ImeiValueLabel.Location = new System.Drawing.Point(79, 128);
            this.ImeiValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ImeiValueLabel.Name = "ImeiValueLabel";
            this.ImeiValueLabel.Size = new System.Drawing.Size(54, 28);
            this.ImeiValueLabel.TabIndex = 30;
            this.ImeiValueLabel.Text = "IMEI:";
            // 
            // MethodDescriptionTextBox
            // 
            this.MethodDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.MethodDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MethodDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MethodDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MethodDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.MethodDescriptionTextBox.Location = new System.Drawing.Point(14, 13);
            this.MethodDescriptionTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.MethodDescriptionTextBox.Multiline = true;
            this.MethodDescriptionTextBox.Name = "MethodDescriptionTextBox";
            this.MethodDescriptionTextBox.ReadOnly = true;
            this.MethodDescriptionTextBox.Size = new System.Drawing.Size(498, 94);
            this.MethodDescriptionTextBox.TabIndex = 30;
            this.MethodDescriptionTextBox.TabStop = false;
            this.MethodDescriptionTextBox.Text = "Перед использованием рекомендуется сохранить исходное значение IMEI, если новое з" +
    "начение не будет соответствовать стандарту.";
            // 
            // ImeiValueTextBox
            // 
            this.ImeiValueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.ImeiValueTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ImeiValueTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ImeiValueTextBox.Location = new System.Drawing.Point(139, 128);
            this.ImeiValueTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ImeiValueTextBox.MaxLength = 15;
            this.ImeiValueTextBox.Name = "ImeiValueTextBox";
            this.ImeiValueTextBox.Size = new System.Drawing.Size(315, 34);
            this.ImeiValueTextBox.TabIndex = 27;
            this.ImeiValueTextBox.TextChanged += new System.EventHandler(this.Imei_Changed);
            this.ImeiValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Imei_KeyboardInput);
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
            this.SaveValuesButton.TabIndex = 2;
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
            this.ResetValuesButton.TabIndex = 3;
            this.ResetValuesButton.Text = "Сбросить изменения";
            this.ResetValuesButton.UseVisualStyleBackColor = false;
            this.ResetValuesButton.Click += new System.EventHandler(this.Button_Click);
            this.ResetValuesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ResetValuesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Method2Panel
            // 
            this.Method2Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Method2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Method2Panel.Controls.Add(this.ImeiValueTextBox);
            this.Method2Panel.Controls.Add(this.ImeiValueLabel);
            this.Method2Panel.Controls.Add(this.MethodDescriptionTextBox);
            this.Method2Panel.Location = new System.Drawing.Point(459, 145);
            this.Method2Panel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Method2Panel.Name = "Method2Panel";
            this.Method2Panel.Size = new System.Drawing.Size(536, 209);
            this.Method2Panel.TabIndex = 61;
            // 
            // Method1Panel
            // 
            this.Method1Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Method1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Method1Panel.Controls.Add(this.MaskButton);
            this.Method1Panel.Location = new System.Drawing.Point(15, 230);
            this.Method1Panel.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.Method1Panel.Name = "Method1Panel";
            this.Method1Panel.Size = new System.Drawing.Size(434, 124);
            this.Method1Panel.TabIndex = 60;
            // 
            // MaskButton
            // 
            this.MaskButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.MaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(222)))), ((int)(((byte)(189)))));
            this.MaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaskButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MaskButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.MaskButton.Image = global::Modem.Properties.Resources.maskBtn;
            this.MaskButton.Location = new System.Drawing.Point(15, 25);
            this.MaskButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.MaskButton.Name = "MaskButton";
            this.MaskButton.Size = new System.Drawing.Size(404, 77);
            this.MaskButton.TabIndex = 4;
            this.MaskButton.Text = "Замаскироваться под мобильное устройство²";
            this.MaskButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MaskButton.UseVisualStyleBackColor = false;
            this.MaskButton.Click += new System.EventHandler(this.Button_Click);
            this.MaskButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.MaskButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ResultPanel
            // 
            this.ResultPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultPanel.Controls.Add(this.CopyButton);
            this.ResultPanel.Controls.Add(this.ResultModemImeiLabel);
            this.ResultPanel.Controls.Add(this.ResultImeiLabel);
            this.ResultPanel.Location = new System.Drawing.Point(15, 145);
            this.ResultPanel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(434, 75);
            this.ResultPanel.TabIndex = 59;
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.FlatAppearance.BorderSize = 0;
            this.CopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.CopyButton.Image = global::Modem.Properties.Resources.copyBtn;
            this.CopyButton.Location = new System.Drawing.Point(358, 23);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(40, 36);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.Button_Click);
            this.CopyButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.CopyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ResultModemImeiLabel
            // 
            this.ResultModemImeiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ResultModemImeiLabel.AutoSize = true;
            this.ResultModemImeiLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultModemImeiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ResultModemImeiLabel.Location = new System.Drawing.Point(170, 23);
            this.ResultModemImeiLabel.Name = "ResultModemImeiLabel";
            this.ResultModemImeiLabel.Size = new System.Drawing.Size(143, 28);
            this.ResultModemImeiLabel.TabIndex = 32;
            this.ResultModemImeiLabel.Text = "[получение...]¹";
            // 
            // ResultImeiLabel
            // 
            this.ResultImeiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ResultImeiLabel.AutoSize = true;
            this.ResultImeiLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultImeiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ResultImeiLabel.Location = new System.Drawing.Point(34, 23);
            this.ResultImeiLabel.Name = "ResultImeiLabel";
            this.ResultImeiLabel.Size = new System.Drawing.Size(130, 28);
            this.ResultImeiLabel.TabIndex = 31;
            this.ResultImeiLabel.Text = "IMEI модема:";
            // 
            // AnnotationTextBox
            // 
            this.AnnotationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AnnotationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.AnnotationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnnotationTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnnotationTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.AnnotationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AnnotationTextBox.Location = new System.Drawing.Point(15, 366);
            this.AnnotationTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.AnnotationTextBox.Multiline = true;
            this.AnnotationTextBox.Name = "AnnotationTextBox";
            this.AnnotationTextBox.Size = new System.Drawing.Size(980, 74);
            this.AnnotationTextBox.TabIndex = 63;
            this.AnnotationTextBox.TabStop = false;
            this.AnnotationTextBox.Text = resources.GetString("AnnotationTextBox.Text");
            // 
            // ImeiPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.AnnotationTextBox);
            this.Controls.Add(this.SaveValuesButton);
            this.Controls.Add(this.ResetValuesButton);
            this.Controls.Add(this.Method2Panel);
            this.Controls.Add(this.Method1Panel);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.PageDescriptionTextBox);
            this.Controls.Add(this.PageTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1020, 680);
            this.Name = "ImeiPage";
            this.Size = new System.Drawing.Size(1020, 680);
            this.Load += new System.EventHandler(this.Page_Load);
            this.Method2Panel.ResumeLayout(false);
            this.Method2Panel.PerformLayout();
            this.Method1Panel.ResumeLayout(false);
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PageDescriptionTextBox;
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.TextBox ImeiValueTextBox;
        private System.Windows.Forms.TextBox MethodDescriptionTextBox;
        private System.Windows.Forms.Label ImeiValueLabel;
        private System.Windows.Forms.Button SaveValuesButton;
        private System.Windows.Forms.Button ResetValuesButton;
        private System.Windows.Forms.Panel Method2Panel;
        private System.Windows.Forms.Panel Method1Panel;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.Label ResultImeiLabel;
        private System.Windows.Forms.Button MaskButton;
        private System.Windows.Forms.TextBox AnnotationTextBox;
        private System.Windows.Forms.Label ResultModemImeiLabel;
        private System.Windows.Forms.Button CopyButton;
    }
}
