namespace DBDRandomizer
{
    partial class Survivor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.perkList = new System.Windows.Forms.ListView();
            this.perkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectAllButton = new System.Windows.Forms.Button();
            this.selectNoneButton = new System.Windows.Forms.Button();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.perkImage1 = new System.Windows.Forms.PictureBox();
            this.perkLabel1 = new System.Windows.Forms.Label();
            this.perkLabel2 = new System.Windows.Forms.Label();
            this.perkImage2 = new System.Windows.Forms.PictureBox();
            this.perkLabel3 = new System.Windows.Forms.Label();
            this.perkImage3 = new System.Windows.Forms.PictureBox();
            this.perkLabel4 = new System.Windows.Forms.Label();
            this.perkImage4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.perkImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perkImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perkImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perkImage4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Select avaliable perks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Randomize it:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. Your perks:";
            // 
            // perkList
            // 
            this.perkList.BackColor = System.Drawing.SystemColors.Window;
            this.perkList.CheckBoxes = true;
            this.perkList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.perkName});
            this.perkList.FullRowSelect = true;
            this.perkList.Location = new System.Drawing.Point(12, 29);
            this.perkList.Name = "perkList";
            this.perkList.Size = new System.Drawing.Size(315, 303);
            this.perkList.TabIndex = 3;
            this.perkList.UseCompatibleStateImageBehavior = false;
            this.perkList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // perkName
            // 
            this.perkName.Text = "Perk";
            this.perkName.Width = 1000;
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(15, 338);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(150, 23);
            this.selectAllButton.TabIndex = 4;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // selectNoneButton
            // 
            this.selectNoneButton.Location = new System.Drawing.Point(171, 338);
            this.selectNoneButton.Name = "selectNoneButton";
            this.selectNoneButton.Size = new System.Drawing.Size(156, 23);
            this.selectNoneButton.TabIndex = 5;
            this.selectNoneButton.Text = "Select None";
            this.selectNoneButton.UseVisualStyleBackColor = true;
            this.selectNoneButton.Click += new System.EventHandler(this.selectNoneButton_Click);
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(333, 29);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(227, 303);
            this.randomizeButton.TabIndex = 6;
            this.randomizeButton.Text = "Randomize!";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // perkImage1
            // 
            this.perkImage1.Location = new System.Drawing.Point(569, 29);
            this.perkImage1.Name = "perkImage1";
            this.perkImage1.Size = new System.Drawing.Size(64, 64);
            this.perkImage1.TabIndex = 7;
            this.perkImage1.TabStop = false;
            // 
            // perkLabel1
            // 
            this.perkLabel1.AutoSize = true;
            this.perkLabel1.Location = new System.Drawing.Point(639, 52);
            this.perkLabel1.Name = "perkLabel1";
            this.perkLabel1.Size = new System.Drawing.Size(0, 13);
            this.perkLabel1.TabIndex = 8;
            // 
            // perkLabel2
            // 
            this.perkLabel2.AutoSize = true;
            this.perkLabel2.Location = new System.Drawing.Point(639, 122);
            this.perkLabel2.Name = "perkLabel2";
            this.perkLabel2.Size = new System.Drawing.Size(0, 13);
            this.perkLabel2.TabIndex = 10;
            // 
            // perkImage2
            // 
            this.perkImage2.Location = new System.Drawing.Point(569, 99);
            this.perkImage2.Name = "perkImage2";
            this.perkImage2.Size = new System.Drawing.Size(64, 64);
            this.perkImage2.TabIndex = 9;
            this.perkImage2.TabStop = false;
            // 
            // perkLabel3
            // 
            this.perkLabel3.AutoSize = true;
            this.perkLabel3.Location = new System.Drawing.Point(639, 192);
            this.perkLabel3.Name = "perkLabel3";
            this.perkLabel3.Size = new System.Drawing.Size(0, 13);
            this.perkLabel3.TabIndex = 12;
            // 
            // perkImage3
            // 
            this.perkImage3.Location = new System.Drawing.Point(569, 169);
            this.perkImage3.Name = "perkImage3";
            this.perkImage3.Size = new System.Drawing.Size(64, 64);
            this.perkImage3.TabIndex = 11;
            this.perkImage3.TabStop = false;
            // 
            // perkLabel4
            // 
            this.perkLabel4.AutoSize = true;
            this.perkLabel4.Location = new System.Drawing.Point(639, 262);
            this.perkLabel4.Name = "perkLabel4";
            this.perkLabel4.Size = new System.Drawing.Size(0, 13);
            this.perkLabel4.TabIndex = 14;
            // 
            // perkImage4
            // 
            this.perkImage4.Location = new System.Drawing.Point(569, 239);
            this.perkImage4.Name = "perkImage4";
            this.perkImage4.Size = new System.Drawing.Size(64, 64);
            this.perkImage4.TabIndex = 13;
            this.perkImage4.TabStop = false;
            // 
            // Survivor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 379);
            this.Controls.Add(this.perkLabel4);
            this.Controls.Add(this.perkImage4);
            this.Controls.Add(this.perkLabel3);
            this.Controls.Add(this.perkImage3);
            this.Controls.Add(this.perkLabel2);
            this.Controls.Add(this.perkImage2);
            this.Controls.Add(this.perkLabel1);
            this.Controls.Add(this.perkImage1);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.selectNoneButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.perkList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(884, 418);
            this.MinimumSize = new System.Drawing.Size(884, 418);
            this.Name = "Survivor";
            this.Text = "Survivor Randomizer";
            this.Load += new System.EventHandler(this.Survivor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perkImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perkImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perkImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perkImage4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView perkList;
        public System.Windows.Forms.ColumnHeader perkName;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button selectNoneButton;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.PictureBox perkImage1;
        private System.Windows.Forms.Label perkLabel1;
        private System.Windows.Forms.Label perkLabel2;
        private System.Windows.Forms.PictureBox perkImage2;
        private System.Windows.Forms.Label perkLabel3;
        private System.Windows.Forms.PictureBox perkImage3;
        private System.Windows.Forms.Label perkLabel4;
        private System.Windows.Forms.PictureBox perkImage4;
    }
}