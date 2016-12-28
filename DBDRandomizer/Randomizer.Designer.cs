namespace DBDRandomizer
{
    partial class Randomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomizer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyNewPerksEveryRollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.suvivorTabPage = new System.Windows.Forms.TabPage();
            this.killerTabPage = new System.Windows.Forms.TabPage();
            this.survivorPerkList = new System.Windows.Forms.ListView();
            this.perkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.survivorSelectNoneButton = new System.Windows.Forms.Button();
            this.survivorSelectAllButton = new System.Windows.Forms.Button();
            this.survivorRandomizeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.survivorPerkLabel4 = new System.Windows.Forms.Label();
            this.survivorPerkImage4 = new System.Windows.Forms.PictureBox();
            this.survivorPerkLabel3 = new System.Windows.Forms.Label();
            this.survivorPerkImage3 = new System.Windows.Forms.PictureBox();
            this.survivorPerkLabel2 = new System.Windows.Forms.Label();
            this.survivorPerkImage2 = new System.Windows.Forms.PictureBox();
            this.survivorPerkLabel1 = new System.Windows.Forms.Label();
            this.survivorPerkImage1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.killerPerkLabel4 = new System.Windows.Forms.Label();
            this.killerPerkImage4 = new System.Windows.Forms.PictureBox();
            this.killerPerkLabel3 = new System.Windows.Forms.Label();
            this.killerPerkImage3 = new System.Windows.Forms.PictureBox();
            this.killerPerkLabel2 = new System.Windows.Forms.Label();
            this.killerPerkImage2 = new System.Windows.Forms.PictureBox();
            this.killerPerkLabel1 = new System.Windows.Forms.Label();
            this.killerPerkImage1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.killerRandomizeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.killerSelectNoneButton = new System.Windows.Forms.Button();
            this.killerSelectAllButton = new System.Windows.Forms.Button();
            this.killerPerkList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.suvivorTabPage.SuspendLayout();
            this.killerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlyNewPerksEveryRollToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // onlyNewPerksEveryRollToolStripMenuItem
            // 
            this.onlyNewPerksEveryRollToolStripMenuItem.CheckOnClick = true;
            this.onlyNewPerksEveryRollToolStripMenuItem.Name = "onlyNewPerksEveryRollToolStripMenuItem";
            this.onlyNewPerksEveryRollToolStripMenuItem.Size = new System.Drawing.Size(301, 30);
            this.onlyNewPerksEveryRollToolStripMenuItem.Text = "Only New Perks Every Roll";
            this.onlyNewPerksEveryRollToolStripMenuItem.Click += new System.EventHandler(this.onlyNewPerksEveryRollToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.suvivorTabPage);
            this.tabControl1.Controls.Add(this.killerTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 663);
            this.tabControl1.TabIndex = 1;
            // 
            // suvivorTabPage
            // 
            this.suvivorTabPage.Controls.Add(this.survivorPerkLabel4);
            this.suvivorTabPage.Controls.Add(this.survivorPerkImage4);
            this.suvivorTabPage.Controls.Add(this.survivorPerkLabel3);
            this.suvivorTabPage.Controls.Add(this.survivorPerkImage3);
            this.suvivorTabPage.Controls.Add(this.survivorPerkLabel2);
            this.suvivorTabPage.Controls.Add(this.survivorPerkImage2);
            this.suvivorTabPage.Controls.Add(this.survivorPerkLabel1);
            this.suvivorTabPage.Controls.Add(this.survivorPerkImage1);
            this.suvivorTabPage.Controls.Add(this.label3);
            this.suvivorTabPage.Controls.Add(this.survivorRandomizeButton);
            this.suvivorTabPage.Controls.Add(this.label2);
            this.suvivorTabPage.Controls.Add(this.survivorSelectNoneButton);
            this.suvivorTabPage.Controls.Add(this.survivorSelectAllButton);
            this.suvivorTabPage.Controls.Add(this.survivorPerkList);
            this.suvivorTabPage.Controls.Add(this.label1);
            this.suvivorTabPage.Location = new System.Drawing.Point(4, 29);
            this.suvivorTabPage.Name = "suvivorTabPage";
            this.suvivorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.suvivorTabPage.Size = new System.Drawing.Size(1374, 630);
            this.suvivorTabPage.TabIndex = 0;
            this.suvivorTabPage.Text = "Survivor";
            this.suvivorTabPage.UseVisualStyleBackColor = true;
            // 
            // killerTabPage
            // 
            this.killerTabPage.Controls.Add(this.killerPerkLabel4);
            this.killerTabPage.Controls.Add(this.killerPerkImage4);
            this.killerTabPage.Controls.Add(this.killerPerkLabel3);
            this.killerTabPage.Controls.Add(this.killerPerkImage3);
            this.killerTabPage.Controls.Add(this.killerPerkLabel2);
            this.killerTabPage.Controls.Add(this.killerPerkImage2);
            this.killerTabPage.Controls.Add(this.killerPerkLabel1);
            this.killerTabPage.Controls.Add(this.killerPerkImage1);
            this.killerTabPage.Controls.Add(this.label8);
            this.killerTabPage.Controls.Add(this.killerRandomizeButton);
            this.killerTabPage.Controls.Add(this.label9);
            this.killerTabPage.Controls.Add(this.killerSelectNoneButton);
            this.killerTabPage.Controls.Add(this.killerSelectAllButton);
            this.killerTabPage.Controls.Add(this.killerPerkList);
            this.killerTabPage.Controls.Add(this.label10);
            this.killerTabPage.Location = new System.Drawing.Point(4, 29);
            this.killerTabPage.Name = "killerTabPage";
            this.killerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.killerTabPage.Size = new System.Drawing.Size(1374, 630);
            this.killerTabPage.TabIndex = 1;
            this.killerTabPage.Text = "Killer";
            this.killerTabPage.UseVisualStyleBackColor = true;
            // 
            // survivorPerkList
            // 
            this.survivorPerkList.BackColor = System.Drawing.SystemColors.Window;
            this.survivorPerkList.CheckBoxes = true;
            this.survivorPerkList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.perkName});
            this.survivorPerkList.FullRowSelect = true;
            this.survivorPerkList.Location = new System.Drawing.Point(9, 44);
            this.survivorPerkList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkList.Name = "survivorPerkList";
            this.survivorPerkList.Size = new System.Drawing.Size(470, 426);
            this.survivorPerkList.TabIndex = 5;
            this.survivorPerkList.UseCompatibleStateImageBehavior = false;
            this.survivorPerkList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // perkName
            // 
            this.perkName.Text = "Perk";
            this.perkName.Width = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "1. Select avaliable perks:";
            // 
            // survivorSelectNoneButton
            // 
            this.survivorSelectNoneButton.Location = new System.Drawing.Point(243, 480);
            this.survivorSelectNoneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorSelectNoneButton.Name = "survivorSelectNoneButton";
            this.survivorSelectNoneButton.Size = new System.Drawing.Size(234, 35);
            this.survivorSelectNoneButton.TabIndex = 7;
            this.survivorSelectNoneButton.Text = "Select None";
            this.survivorSelectNoneButton.UseVisualStyleBackColor = true;
            this.survivorSelectNoneButton.Click += new System.EventHandler(this.survivorSelectNoneButton_Click);
            // 
            // survivorSelectAllButton
            // 
            this.survivorSelectAllButton.Location = new System.Drawing.Point(9, 480);
            this.survivorSelectAllButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorSelectAllButton.Name = "survivorSelectAllButton";
            this.survivorSelectAllButton.Size = new System.Drawing.Size(225, 35);
            this.survivorSelectAllButton.TabIndex = 6;
            this.survivorSelectAllButton.Text = "Select All";
            this.survivorSelectAllButton.UseVisualStyleBackColor = true;
            this.survivorSelectAllButton.Click += new System.EventHandler(this.survivorSelectAllButton_Click);
            // 
            // survivorRandomizeButton
            // 
            this.survivorRandomizeButton.Location = new System.Drawing.Point(487, 44);
            this.survivorRandomizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorRandomizeButton.Name = "survivorRandomizeButton";
            this.survivorRandomizeButton.Size = new System.Drawing.Size(340, 466);
            this.survivorRandomizeButton.TabIndex = 9;
            this.survivorRandomizeButton.Text = "Randomize!";
            this.survivorRandomizeButton.UseVisualStyleBackColor = true;
            this.survivorRandomizeButton.Click += new System.EventHandler(this.survivorRandomizeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "2. Randomize it:";
            // 
            // survivorPerkLabel4
            // 
            this.survivorPerkLabel4.AutoSize = true;
            this.survivorPerkLabel4.Location = new System.Drawing.Point(939, 402);
            this.survivorPerkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.survivorPerkLabel4.Name = "survivorPerkLabel4";
            this.survivorPerkLabel4.Size = new System.Drawing.Size(0, 20);
            this.survivorPerkLabel4.TabIndex = 23;
            // 
            // survivorPerkImage4
            // 
            this.survivorPerkImage4.Location = new System.Drawing.Point(835, 367);
            this.survivorPerkImage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkImage4.Name = "survivorPerkImage4";
            this.survivorPerkImage4.Size = new System.Drawing.Size(96, 98);
            this.survivorPerkImage4.TabIndex = 22;
            this.survivorPerkImage4.TabStop = false;
            // 
            // survivorPerkLabel3
            // 
            this.survivorPerkLabel3.AutoSize = true;
            this.survivorPerkLabel3.Location = new System.Drawing.Point(939, 294);
            this.survivorPerkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.survivorPerkLabel3.Name = "survivorPerkLabel3";
            this.survivorPerkLabel3.Size = new System.Drawing.Size(0, 20);
            this.survivorPerkLabel3.TabIndex = 21;
            // 
            // survivorPerkImage3
            // 
            this.survivorPerkImage3.Location = new System.Drawing.Point(835, 259);
            this.survivorPerkImage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkImage3.Name = "survivorPerkImage3";
            this.survivorPerkImage3.Size = new System.Drawing.Size(96, 98);
            this.survivorPerkImage3.TabIndex = 20;
            this.survivorPerkImage3.TabStop = false;
            // 
            // survivorPerkLabel2
            // 
            this.survivorPerkLabel2.AutoSize = true;
            this.survivorPerkLabel2.Location = new System.Drawing.Point(939, 187);
            this.survivorPerkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.survivorPerkLabel2.Name = "survivorPerkLabel2";
            this.survivorPerkLabel2.Size = new System.Drawing.Size(0, 20);
            this.survivorPerkLabel2.TabIndex = 19;
            // 
            // survivorPerkImage2
            // 
            this.survivorPerkImage2.Location = new System.Drawing.Point(835, 151);
            this.survivorPerkImage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkImage2.Name = "survivorPerkImage2";
            this.survivorPerkImage2.Size = new System.Drawing.Size(96, 98);
            this.survivorPerkImage2.TabIndex = 18;
            this.survivorPerkImage2.TabStop = false;
            // 
            // survivorPerkLabel1
            // 
            this.survivorPerkLabel1.AutoSize = true;
            this.survivorPerkLabel1.Location = new System.Drawing.Point(939, 79);
            this.survivorPerkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.survivorPerkLabel1.Name = "survivorPerkLabel1";
            this.survivorPerkLabel1.Size = new System.Drawing.Size(0, 20);
            this.survivorPerkLabel1.TabIndex = 17;
            // 
            // survivorPerkImage1
            // 
            this.survivorPerkImage1.Location = new System.Drawing.Point(835, 44);
            this.survivorPerkImage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkImage1.Name = "survivorPerkImage1";
            this.survivorPerkImage1.Size = new System.Drawing.Size(96, 98);
            this.survivorPerkImage1.TabIndex = 16;
            this.survivorPerkImage1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(830, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "3. Your perks:";
            // 
            // killerPerkLabel4
            // 
            this.killerPerkLabel4.AutoSize = true;
            this.killerPerkLabel4.Location = new System.Drawing.Point(939, 402);
            this.killerPerkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.killerPerkLabel4.Name = "killerPerkLabel4";
            this.killerPerkLabel4.Size = new System.Drawing.Size(0, 20);
            this.killerPerkLabel4.TabIndex = 38;
            // 
            // killerPerkImage4
            // 
            this.killerPerkImage4.Location = new System.Drawing.Point(835, 367);
            this.killerPerkImage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkImage4.Name = "killerPerkImage4";
            this.killerPerkImage4.Size = new System.Drawing.Size(96, 98);
            this.killerPerkImage4.TabIndex = 37;
            this.killerPerkImage4.TabStop = false;
            // 
            // killerPerkLabel3
            // 
            this.killerPerkLabel3.AutoSize = true;
            this.killerPerkLabel3.Location = new System.Drawing.Point(939, 294);
            this.killerPerkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.killerPerkLabel3.Name = "killerPerkLabel3";
            this.killerPerkLabel3.Size = new System.Drawing.Size(0, 20);
            this.killerPerkLabel3.TabIndex = 36;
            // 
            // killerPerkImage3
            // 
            this.killerPerkImage3.Location = new System.Drawing.Point(835, 259);
            this.killerPerkImage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkImage3.Name = "killerPerkImage3";
            this.killerPerkImage3.Size = new System.Drawing.Size(96, 98);
            this.killerPerkImage3.TabIndex = 35;
            this.killerPerkImage3.TabStop = false;
            // 
            // killerPerkLabel2
            // 
            this.killerPerkLabel2.AutoSize = true;
            this.killerPerkLabel2.Location = new System.Drawing.Point(939, 187);
            this.killerPerkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.killerPerkLabel2.Name = "killerPerkLabel2";
            this.killerPerkLabel2.Size = new System.Drawing.Size(0, 20);
            this.killerPerkLabel2.TabIndex = 34;
            // 
            // killerPerkImage2
            // 
            this.killerPerkImage2.Location = new System.Drawing.Point(835, 151);
            this.killerPerkImage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkImage2.Name = "killerPerkImage2";
            this.killerPerkImage2.Size = new System.Drawing.Size(96, 98);
            this.killerPerkImage2.TabIndex = 33;
            this.killerPerkImage2.TabStop = false;
            // 
            // killerPerkLabel1
            // 
            this.killerPerkLabel1.AutoSize = true;
            this.killerPerkLabel1.Location = new System.Drawing.Point(939, 79);
            this.killerPerkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.killerPerkLabel1.Name = "killerPerkLabel1";
            this.killerPerkLabel1.Size = new System.Drawing.Size(0, 20);
            this.killerPerkLabel1.TabIndex = 32;
            // 
            // killerPerkImage1
            // 
            this.killerPerkImage1.Location = new System.Drawing.Point(835, 44);
            this.killerPerkImage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkImage1.Name = "killerPerkImage1";
            this.killerPerkImage1.Size = new System.Drawing.Size(96, 98);
            this.killerPerkImage1.TabIndex = 31;
            this.killerPerkImage1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(830, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "3. Your perks:";
            // 
            // killerRandomizeButton
            // 
            this.killerRandomizeButton.Location = new System.Drawing.Point(487, 44);
            this.killerRandomizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerRandomizeButton.Name = "killerRandomizeButton";
            this.killerRandomizeButton.Size = new System.Drawing.Size(340, 466);
            this.killerRandomizeButton.TabIndex = 29;
            this.killerRandomizeButton.Text = "Randomize!";
            this.killerRandomizeButton.UseVisualStyleBackColor = true;
            this.killerRandomizeButton.Click += new System.EventHandler(this.killerRandomizeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "2. Randomize it:";
            // 
            // killerSelectNoneButton
            // 
            this.killerSelectNoneButton.Location = new System.Drawing.Point(243, 480);
            this.killerSelectNoneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerSelectNoneButton.Name = "killerSelectNoneButton";
            this.killerSelectNoneButton.Size = new System.Drawing.Size(234, 35);
            this.killerSelectNoneButton.TabIndex = 27;
            this.killerSelectNoneButton.Text = "Select None";
            this.killerSelectNoneButton.UseVisualStyleBackColor = true;
            this.killerSelectNoneButton.Click += new System.EventHandler(this.killerSelectNoneButton_Click);
            // 
            // killerSelectAllButton
            // 
            this.killerSelectAllButton.Location = new System.Drawing.Point(9, 480);
            this.killerSelectAllButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerSelectAllButton.Name = "killerSelectAllButton";
            this.killerSelectAllButton.Size = new System.Drawing.Size(225, 35);
            this.killerSelectAllButton.TabIndex = 26;
            this.killerSelectAllButton.Text = "Select All";
            this.killerSelectAllButton.UseVisualStyleBackColor = true;
            this.killerSelectAllButton.Click += new System.EventHandler(this.killerSelectAllButton_Click);
            // 
            // killerPerkList
            // 
            this.killerPerkList.BackColor = System.Drawing.SystemColors.Window;
            this.killerPerkList.CheckBoxes = true;
            this.killerPerkList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.killerPerkList.FullRowSelect = true;
            this.killerPerkList.Location = new System.Drawing.Point(9, 44);
            this.killerPerkList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkList.Name = "killerPerkList";
            this.killerPerkList.Size = new System.Drawing.Size(470, 426);
            this.killerPerkList.TabIndex = 25;
            this.killerPerkList.UseCompatibleStateImageBehavior = false;
            this.killerPerkList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Perk";
            this.columnHeader1.Width = 1000;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "1. Select avaliable perks:";
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 594);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1315, 650);
            this.MinimumSize = new System.Drawing.Size(1315, 650);
            this.Name = "Randomizer";
            this.Text = "Randomizer";
            this.Load += new System.EventHandler(this.Randomizer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.suvivorTabPage.ResumeLayout(false);
            this.suvivorTabPage.PerformLayout();
            this.killerTabPage.ResumeLayout(false);
            this.killerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyNewPerksEveryRollToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage suvivorTabPage;
        private System.Windows.Forms.TabPage killerTabPage;
        private System.Windows.Forms.ListView survivorPerkList;
        public System.Windows.Forms.ColumnHeader perkName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button survivorSelectNoneButton;
        private System.Windows.Forms.Button survivorSelectAllButton;
        private System.Windows.Forms.Button survivorRandomizeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label survivorPerkLabel4;
        private System.Windows.Forms.PictureBox survivorPerkImage4;
        private System.Windows.Forms.Label survivorPerkLabel3;
        private System.Windows.Forms.PictureBox survivorPerkImage3;
        private System.Windows.Forms.Label survivorPerkLabel2;
        private System.Windows.Forms.PictureBox survivorPerkImage2;
        private System.Windows.Forms.Label survivorPerkLabel1;
        private System.Windows.Forms.PictureBox survivorPerkImage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label killerPerkLabel4;
        private System.Windows.Forms.PictureBox killerPerkImage4;
        private System.Windows.Forms.Label killerPerkLabel3;
        private System.Windows.Forms.PictureBox killerPerkImage3;
        private System.Windows.Forms.Label killerPerkLabel2;
        private System.Windows.Forms.PictureBox killerPerkImage2;
        private System.Windows.Forms.Label killerPerkLabel1;
        private System.Windows.Forms.PictureBox killerPerkImage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button killerRandomizeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button killerSelectNoneButton;
        private System.Windows.Forms.Button killerSelectAllButton;
        private System.Windows.Forms.ListView killerPerkList;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label10;
    }
}