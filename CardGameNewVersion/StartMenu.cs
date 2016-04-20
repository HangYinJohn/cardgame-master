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
    public partial class StartMenu : Form
    {
        Controller myController;

        public StartMenu()
        {
            InitializeComponent();
        }

        public void SetController(Controller theController)
        {
            myController = theController;
        }

        private void PokemonBtn_Click(object sender, EventArgs e)
        {
            myController.CardsSelected("pokemon", this);
        }

        private void PhotoBtn_Click(object sender, EventArgs e)
        {
            myController.CardsSelected("stuff", this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
