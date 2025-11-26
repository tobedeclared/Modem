namespace Modem.Pages
{
    partial class FrequencyPage
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
            this.RatGroupBox = new System.Windows.Forms.GroupBox();
            this.BandsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DefaultValuesButton = new System.Windows.Forms.Button();
            this.SaveValuesButton = new System.Windows.Forms.Button();
            this.ResetValuesButton = new System.Windows.Forms.Button();
            this.RatGroupBox.SuspendLayout();
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
            this.PageDescriptionTextBox.Size = new System.Drawing.Size(975, 65);
            this.PageDescriptionTextBox.TabIndex = 32;
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
            this.PageTitleLabel.Size = new System.Drawing.Size(276, 67);
            this.PageTitleLabel.TabIndex = 31;
            this.PageTitleLabel.Text = "Частотный диапазон";
            // 
            // RatGroupBox
            // 
            this.RatGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RatGroupBox.Controls.Add(this.BandsFlowLayoutPanel);
            this.RatGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RatGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RatGroupBox.Location = new System.Drawing.Point(15, 145);
            this.RatGroupBox.Name = "RatGroupBox";
            this.RatGroupBox.Size = new System.Drawing.Size(977, 102);
            this.RatGroupBox.TabIndex = 57;
            this.RatGroupBox.TabStop = false;
            this.RatGroupBox.Text = "Диапазон частот для [получение данных...] сети";
            // 
            // BandsFlowLayoutPanel
            // 
            this.BandsFlowLayoutPanel.Location = new System.Drawing.Point(27, 33);
            this.BandsFlowLayoutPanel.Name = "BandsFlowLayoutPanel";
            this.BandsFlowLayoutPanel.Size = new System.Drawing.Size(927, 50);
            this.BandsFlowLayoutPanel.TabIndex = 61;
            // 
            // DefaultValuesButton
            // 
            this.DefaultValuesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DefaultValuesButton.FlatAppearance.BorderSize = 0;
            this.DefaultValuesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DefaultValuesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DefaultValuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultValuesButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DefaultValuesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.DefaultValuesButton.Location = new System.Drawing.Point(15, 611);
            this.DefaultValuesButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.DefaultValuesButton.Name = "DefaultValuesButton";
            this.DefaultValuesButton.Size = new System.Drawing.Size(377, 36);
            this.DefaultValuesButton.TabIndex = 42;
            this.DefaultValuesButton.Text = "Восстановить значения по умолчанию";
            this.DefaultValuesButton.UseVisualStyleBackColor = false;
            this.DefaultValuesButton.Click += new System.EventHandler(this.Button_Click);
            this.DefaultValuesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.DefaultValuesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
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
            this.ResetValuesButton.Location = new System.Drawing.Point(542, 611);
            this.ResetValuesButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ResetValuesButton.Name = "ResetValuesButton";
            this.ResetValuesButton.Size = new System.Drawing.Size(217, 36);
            this.ResetValuesButton.TabIndex = 41;
            this.ResetValuesButton.Text = "Сбросить изменения";
            this.ResetValuesButton.UseVisualStyleBackColor = false;
            this.ResetValuesButton.Click += new System.EventHandler(this.Button_Click);
            this.ResetValuesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ResetValuesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // FrequencyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.ResetValuesButton);
            this.Controls.Add(this.SaveValuesButton);
            this.Controls.Add(this.DefaultValuesButton);
            this.Controls.Add(this.RatGroupBox);
            this.Controls.Add(this.PageDescriptionTextBox);
            this.Controls.Add(this.PageTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1020, 680);
            this.Name = "FrequencyPage";
            this.Size = new System.Drawing.Size(1020, 680);
            this.Load += new System.EventHandler(this.Page_Load);
            this.RatGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PageDescriptionTextBox;
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.GroupBox RatGroupBox;
        private System.Windows.Forms.FlowLayoutPanel BandsFlowLayoutPanel;
        private System.Windows.Forms.Button SaveValuesButton;
        private System.Windows.Forms.Button DefaultValuesButton;
        private System.Windows.Forms.Button ResetValuesButton;
    }
}
