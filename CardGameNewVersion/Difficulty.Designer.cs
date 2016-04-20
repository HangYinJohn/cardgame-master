namespace CardGameNewVersion
{
    partial class Difficulty
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lvl3 = new System.Windows.Forms.PictureBox();
            this.Lvl2 = new System.Windows.Forms.PictureBox();
            this.Lvl1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CardGameNewVersion.Properties.Resources.X;
            this.pictureBox1.Location = new System.Drawing.Point(45, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // Lvl3
            // 
            this.Lvl3.BackgroundImage = global::CardGameNewVersion.Properties.Resources.Hard1;
            this.Lvl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Lvl3.Location = new System.Drawing.Point(689, 78);
            this.Lvl3.Name = "Lvl3";
            this.Lvl3.Size = new System.Drawing.Size(298, 574);
            this.Lvl3.TabIndex = 2;
            this.Lvl3.TabStop = false;
            this.Lvl3.Click += new System.EventHandler(this.Lvl3_Click);
            // 
            // Lvl2
            // 
            this.Lvl2.BackgroundImage = global::CardGameNewVersion.Properties.Resources.Medium1;
            this.Lvl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Lvl2.Location = new System.Drawing.Point(362, 78);
            this.Lvl2.Name = "Lvl2";
            this.Lvl2.Size = new System.Drawing.Size(298, 574);
            this.Lvl2.TabIndex = 1;
            this.Lvl2.TabStop = false;
            this.Lvl2.Click += new System.EventHandler(this.Lvl2_Click);
            // 
            // Lvl1
            // 
            this.Lvl1.BackgroundImage = global::CardGameNewVersion.Properties.Resources.Easy1;
            this.Lvl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Lvl1.Location = new System.Drawing.Point(35, 78);
            this.Lvl1.Name = "Lvl1";
            this.Lvl1.Size = new System.Drawing.Size(298, 574);
            this.Lvl1.TabIndex = 0;
            this.Lvl1.TabStop = false;
            this.Lvl1.Click += new System.EventHandler(this.Lvl1_Click);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lvl3);
            this.Controls.Add(this.Lvl2);
            this.Controls.Add(this.Lvl1);
            this.Name = "Difficulty";
            this.Text = "Difficulty";
            this.Load += new System.EventHandler(this.Difficulty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Lvl1;
        private System.Windows.Forms.PictureBox Lvl2;
        private System.Windows.Forms.PictureBox Lvl3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}