namespace ChefManager.popup
{
    partial class LanguageSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageSettingForm));
            this.LangSettingOkBtn = new System.Windows.Forms.Button();
            this.LangSettingCancelBtn = new System.Windows.Forms.Button();
            this.LangComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LangSettingOkBtn
            // 
            this.LangSettingOkBtn.Location = new System.Drawing.Point(106, 49);
            this.LangSettingOkBtn.Name = "LangSettingOkBtn";
            this.LangSettingOkBtn.Size = new System.Drawing.Size(80, 32);
            this.LangSettingOkBtn.TabIndex = 0;
            this.LangSettingOkBtn.Text = "Ok";
            this.LangSettingOkBtn.UseVisualStyleBackColor = true;
            this.LangSettingOkBtn.Click += new System.EventHandler(this.LangSettingOkBtn_Click);
            // 
            // LangSettingCancelBtn
            // 
            this.LangSettingCancelBtn.Location = new System.Drawing.Point(192, 49);
            this.LangSettingCancelBtn.Name = "LangSettingCancelBtn";
            this.LangSettingCancelBtn.Size = new System.Drawing.Size(80, 32);
            this.LangSettingCancelBtn.TabIndex = 1;
            this.LangSettingCancelBtn.Text = "Cancel";
            this.LangSettingCancelBtn.UseVisualStyleBackColor = true;
            // 
            // LangComboBox
            // 
            this.LangComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangComboBox.FormattingEnabled = true;
            this.LangComboBox.Location = new System.Drawing.Point(12, 12);
            this.LangComboBox.Name = "LangComboBox";
            this.LangComboBox.Size = new System.Drawing.Size(260, 20);
            this.LangComboBox.TabIndex = 2;
            // 
            // LanguageSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.LangComboBox);
            this.Controls.Add(this.LangSettingCancelBtn);
            this.Controls.Add(this.LangSettingOkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LanguageSettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Language Setting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LangSettingOkBtn;
        private System.Windows.Forms.Button LangSettingCancelBtn;
        private System.Windows.Forms.ComboBox LangComboBox;
    }
}