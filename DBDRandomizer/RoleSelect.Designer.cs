namespace DBDRandomizer
{
    partial class RoleSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleSelect));
            this.survivorButton = new System.Windows.Forms.Button();
            this.killerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // survivorButton
            // 
            this.survivorButton.Image = ((System.Drawing.Image)(resources.GetObject("survivorButton.Image")));
            this.survivorButton.Location = new System.Drawing.Point(12, 43);
            this.survivorButton.Name = "survivorButton";
            this.survivorButton.Size = new System.Drawing.Size(220, 231);
            this.survivorButton.TabIndex = 0;
            this.survivorButton.Text = "Suvivors";
            this.survivorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.survivorButton.UseVisualStyleBackColor = true;
            this.survivorButton.Click += new System.EventHandler(this.survivorButton_Click);
            // 
            // killerButton
            // 
            this.killerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.killerButton.Image = ((System.Drawing.Image)(resources.GetObject("killerButton.Image")));
            this.killerButton.Location = new System.Drawing.Point(261, 43);
            this.killerButton.Name = "killerButton";
            this.killerButton.Size = new System.Drawing.Size(220, 231);
            this.killerButton.TabIndex = 1;
            this.killerButton.Text = "Killers";
            this.killerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.killerButton.UseVisualStyleBackColor = true;
            this.killerButton.Click += new System.EventHandler(this.killerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(12, 280);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(469, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Quit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select your role:";
            // 
            // RoleSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.killerButton);
            this.Controls.Add(this.survivorButton);
            this.MaximumSize = new System.Drawing.Size(509, 354);
            this.MinimumSize = new System.Drawing.Size(509, 354);
            this.Name = "RoleSelect";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DBDRandomizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button survivorButton;
        private System.Windows.Forms.Button killerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

