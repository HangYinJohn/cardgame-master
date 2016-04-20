namespace CardGameNewVersion
{
    partial class StartMenu
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
            this.PhotoBtn = new System.Windows.Forms.PictureBox();
            this.PokemonBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CardGameNewVersion.Properties.Resources.X2;
            this.pictureBox1.Location = new System.Drawing.Point(45, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // PhotoBtn
            // 
            this.PhotoBtn.Location = new System.Drawing.Point(529, 66);
            this.PhotoBtn.Name = "PhotoBtn";
            this.PhotoBtn.Size = new System.Drawing.Size(410, 591);
            this.PhotoBtn.TabIndex = 1;
            this.PhotoBtn.TabStop = false;
            this.PhotoBtn.Click += new System.EventHandler(this.PhotoBtn_Click);
            // 
            // PokemonBtn
            // 
            this.PokemonBtn.BackgroundImage = global::CardGameNewVersion.Properties.Resources.pokem;
            this.PokemonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PokemonBtn.Location = new System.Drawing.Point(88, 66);
            this.PokemonBtn.Name = "PokemonBtn";
            this.PokemonBtn.Size = new System.Drawing.Size(410, 591);
            this.PokemonBtn.TabIndex = 0;
            this.PokemonBtn.TabStop = false;
            this.PokemonBtn.Click += new System.EventHandler(this.PokemonBtn_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PhotoBtn);
            this.Controls.Add(this.PokemonBtn);
            this.Name = "StartMenu";
            this.Text = "Start Menu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PokemonBtn;
        private System.Windows.Forms.PictureBox PhotoBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

