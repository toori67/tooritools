namespace ChefManager
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.appMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openIngredientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadIngredientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewIngredientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutohideTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.appMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // appMenuStrip
            // 
            this.appMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.addToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.appMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.appMenuStrip.Name = "appMenuStrip";
            this.appMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.appMenuStrip.TabIndex = 0;
            this.appMenuStrip.TabStop = true;
            this.appMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveDataMenuItem,
            this.exportToolStripMenuItem});
            this.fileMenuItem.Image = global::ChefManager.Properties.Resources.Rock_Paper_Scissors_Paper_icon;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAllDataMenuItem,
            this.openIngredientMenuItem,
            this.openRecipeMenuItem});
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "open(...)";
            // 
            // openAllDataMenuItem
            // 
            this.openAllDataMenuItem.Image = global::ChefManager.Properties.Resources.Gamble_Cards_icon;
            this.openAllDataMenuItem.Name = "openAllDataMenuItem";
            this.openAllDataMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openAllDataMenuItem.Text = "All";
            // 
            // openIngredientMenuItem
            // 
            this.openIngredientMenuItem.Image = global::ChefManager.Properties.Resources.Kitchen_Bunch_ingredients_icon;
            this.openIngredientMenuItem.Name = "openIngredientMenuItem";
            this.openIngredientMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openIngredientMenuItem.Text = "Ingredient";
            // 
            // openRecipeMenuItem
            // 
            this.openRecipeMenuItem.Image = global::ChefManager.Properties.Resources.Kitchen_Coking_pot_icon;
            this.openRecipeMenuItem.Name = "openRecipeMenuItem";
            this.openRecipeMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openRecipeMenuItem.Text = "Recipe";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAllMenuItem,
            this.loadIngredientMenuItem,
            this.loadRecipeMenuItem});
            this.loadToolStripMenuItem.Image = global::ChefManager.Properties.Resources.Updates_Downloading_updates_icon;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.loadToolStripMenuItem.Text = "Load(...)";
            // 
            // loadAllMenuItem
            // 
            this.loadAllMenuItem.Image = global::ChefManager.Properties.Resources.Gamble_Cards_icon;
            this.loadAllMenuItem.Name = "loadAllMenuItem";
            this.loadAllMenuItem.Size = new System.Drawing.Size(128, 22);
            this.loadAllMenuItem.Text = "All ";
            // 
            // loadIngredientMenuItem
            // 
            this.loadIngredientMenuItem.Image = global::ChefManager.Properties.Resources.Kitchen_Bunch_ingredients_icon;
            this.loadIngredientMenuItem.Name = "loadIngredientMenuItem";
            this.loadIngredientMenuItem.Size = new System.Drawing.Size(128, 22);
            this.loadIngredientMenuItem.Text = "Ingredient";
            // 
            // loadRecipeMenuItem
            // 
            this.loadRecipeMenuItem.Image = global::ChefManager.Properties.Resources.Kitchen_Coking_pot_icon;
            this.loadRecipeMenuItem.Name = "loadRecipeMenuItem";
            this.loadRecipeMenuItem.Size = new System.Drawing.Size(128, 22);
            this.loadRecipeMenuItem.Text = "Recipe";
            // 
            // saveDataMenuItem
            // 
            this.saveDataMenuItem.Image = global::ChefManager.Properties.Resources.System_Save_icon;
            this.saveDataMenuItem.Name = "saveDataMenuItem";
            this.saveDataMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveDataMenuItem.Text = "Save(...)";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::ChefManager.Properties.Resources.Very_Basic_Upload_icon;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exportToolStripMenuItem.Text = "Export(...)";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewIngredientMenuItem,
            this.addNewRecipeMenuItem});
            this.addToolStripMenuItem.Image = global::ChefManager.Properties.Resources.Very_Basic_Plus_icon;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewIngredientMenuItem
            // 
            this.addNewIngredientMenuItem.Image = global::ChefManager.Properties.Resources.Kitchen_Bunch_ingredients_icon;
            this.addNewIngredientMenuItem.Name = "addNewIngredientMenuItem";
            this.addNewIngredientMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addNewIngredientMenuItem.Text = "New Ingredient";
            // 
            // addNewRecipeMenuItem
            // 
            this.addNewRecipeMenuItem.Image = global::ChefManager.Properties.Resources.Kitchen_Coking_pot_icon;
            this.addNewRecipeMenuItem.Name = "addNewRecipeMenuItem";
            this.addNewRecipeMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addNewRecipeMenuItem.Text = "New Recipe";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageMenuItem,
            this.whoMenuItem});
            this.optionToolStripMenuItem.Image = global::ChefManager.Properties.Resources.Very_Basic_Settings_icon;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // languageMenuItem
            // 
            this.languageMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("languageMenuItem.Image")));
            this.languageMenuItem.Name = "languageMenuItem";
            this.languageMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageMenuItem.Text = "Language";
            this.languageMenuItem.Click += new System.EventHandler(this.languageMenuItem_Click);
            // 
            // whoMenuItem
            // 
            this.whoMenuItem.Image = global::ChefManager.Properties.Resources.QutIM_Conference_icon;
            this.whoMenuItem.Name = "whoMenuItem";
            this.whoMenuItem.Size = new System.Drawing.Size(126, 22);
            this.whoMenuItem.Text = "Who?";
            // 
            // menuAutohideTimer
            // 
            this.menuAutohideTimer.Enabled = true;
            this.menuAutohideTimer.Tick += new System.EventHandler(this.menuAutohideTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 537);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.appMenuStrip);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Chef Manger V - 0.1";
            this.appMenuStrip.ResumeLayout(false);
            this.appMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip appMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewIngredientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadIngredientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAllDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openIngredientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataMenuItem;
        private System.Windows.Forms.Timer menuAutohideTimer;
        private System.Windows.Forms.Panel panel1;

    }
}

