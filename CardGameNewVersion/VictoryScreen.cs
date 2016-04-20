using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGameNewVersion
{
    public partial class VictoryScreen : Form
    {
        public VictoryScreen()
        {
            InitializeComponent();
            VictoryPic.Image = Properties.Resources.fireworks_transparent_fireworks_animated;
            VictoryPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            StartMenu myForm = new StartMenu();
            myForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
