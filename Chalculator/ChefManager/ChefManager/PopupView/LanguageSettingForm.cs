using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChefManager.Controller;
using ChefManager.Resources.language;

namespace ChefManager.popup
{
    public partial class LanguageSettingForm : Form
    {

        public LanguageSettingForm()
        {
            InitializeComponent();
            setTexts();
            LangComboBox.Items.AddRange(Languages.GetByArray());
            LangComboBox.SelectedIndex = 0;
            
        }
        private void setTexts()
        {
            this.Text = MenuAndDesc.lang_title;
            LangSettingOkBtn.Text = MenuAndDesc.ok;
            LangSettingCancelBtn.Text = MenuAndDesc.cancel;
        }

        private void LangSettingOkBtn_Click(object sender, EventArgs e)
        {
            LanguageDataManager.SetLanguage(Languages.GetLanguageCulture((String)LangComboBox.SelectedItem));
            setTexts();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
