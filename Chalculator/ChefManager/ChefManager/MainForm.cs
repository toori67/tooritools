using ChefManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChefManager.popup;
using ChefManager.Resources.language;

//icon resource
//http://www.iconarchive.com/show/icons8-metro-style-icons-by-visualpharm.21.html
//
namespace ChefManager
{
    public partial class MainForm : Form
    {
        LanguageSettingForm lsf = new LanguageSettingForm();
        bool isMenuOpened = false;
        public MainForm()
        {
            InitializeComponent();
            appMenuStrip.Visible = false;

            foreach (ToolStripMenuItem m in appMenuStrip.Items)
            {
                m.DropDownOpened += m_DropDownOpened;
                m.DropDownClosed += m_DropDownClosed;
            }

            setTexts();

        }

        private void languageMenuItem_Click(object sender, EventArgs e)
        {
            if (lsf.ShowDialog() == DialogResult.OK)
            {
                setTexts();
            }
        }
        private void setTexts()
        {
            this.Text = MenuAndDesc.title;

            this.fileMenuItem.Text = MenuAndDesc.fle;
            this.openToolStripMenuItem.Text = MenuAndDesc.open;
            this.openAllDataMenuItem.Text = MenuAndDesc.all;
            this.openIngredientMenuItem.Text = MenuAndDesc.ingredient;
            this.openRecipeMenuItem.Text = MenuAndDesc.recipe;

            this.loadToolStripMenuItem.Text = MenuAndDesc.load;
            this.loadAllMenuItem.Text = MenuAndDesc.all;
            this.loadIngredientMenuItem.Text = MenuAndDesc.ingredient;
            this.loadRecipeMenuItem.Text = MenuAndDesc.recipe;

            this.saveDataMenuItem.Text = MenuAndDesc.save;
            this.exportToolStripMenuItem.Text = MenuAndDesc.export;

            this.addToolStripMenuItem.Text = MenuAndDesc.add;
            this.addNewIngredientMenuItem.Text = MenuAndDesc.new_ing;
            this.addNewRecipeMenuItem.Text = MenuAndDesc.new_rec;

            this.optionToolStripMenuItem.Text = MenuAndDesc.option;
            this.languageMenuItem.Text = MenuAndDesc.lang;
            this.whoMenuItem.Text = MenuAndDesc.who;
        }

        private void menuAutohideTimer_Tick(object sender, EventArgs e)
        {
            Point currentCursor = PointToClient(MousePosition);
            if (currentCursor.Y <= appMenuStrip.Height && currentCursor.Y >= 0)
            {
                appMenuStrip.Visible = true;
            }
            else
            {
                if (!isMenuOpened)
                {
                    appMenuStrip.Visible = false;
                }
            }
        }
        void m_DropDownClosed(object sender, EventArgs e)
        {
            isMenuOpened = false;
        }

        void m_DropDownOpened(object sender, EventArgs e)
        {
            isMenuOpened = true;
        }
    }
}