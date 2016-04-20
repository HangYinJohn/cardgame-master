namespace CardGameNewVersion
{
    partial class VictoryScreen
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
            this.VictoryPic = new System.Windows.Forms.PictureBox();
            this.VictoryText = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VictoryPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // VictoryPic
            // 
            this.VictoryPic.BackgroundImage = global::CardGameNewVersion.Properties.Resources.fireworks_transparent_fireworks_animated;
            this.VictoryPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VictoryPic.Location = new System.Drawing.Point(70, 54);
            this.VictoryPic.Name = "VictoryPic";
            this.VictoryPic.Size = new System.Drawing.Size(886, 435);
            this.VictoryPic.TabIndex = 0;
            this.VictoryPic.TabStop = false;
            // 
            // VictoryText
            // 
            this.VictoryText.AutoSize = true;
            this.VictoryText.Font = new System.Drawing.Font("Playbill", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VictoryText.Location = new System.Drawing.Point(356, 562);
            this.VictoryText.Name = "VictoryText";
            this.VictoryText.Size = new System.Drawing.Size(292, 98);
            this.VictoryText.TabIndex = 1;
            this.VictoryText.Text = "Well done!";
            // 
            // PlayAgain
            // 
            this.PlayAgain.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.Location = new System.Drawing.Point(789, 649);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(167, 69);
            this.PlayAgain.TabIndex = 3;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::CardGameNewVersion.Properties.Resources.X;
            this.ExitButton.Location = new System.Drawing.Point(13, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(51, 50);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 18;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // VictoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.VictoryText);
            this.Controls.Add(this.VictoryPic);
            this.Name = "VictoryScreen";
            this.Text = "VictoryScreen";
            ((System.ComponentModel.ISupportInitialize)(this.VictoryPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VictoryPic;
        private System.Windows.Forms.Label VictoryText;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.PictureBox ExitButton;
    }
}