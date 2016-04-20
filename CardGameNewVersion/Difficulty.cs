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
    public partial class Difficulty : Form
    {
        Controller myController;
        public Difficulty()
        {
            InitializeComponent();
        }



        public void SetController(Controller theController)
        {
            myController = theController;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Difficulty_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lvl1_Click(object sender, EventArgs e)
        {
            myController.SelectDifficulty(4, this);
        }

        private void Lvl2_Click(object sender, EventArgs e)
        {
            myController.SelectDifficulty(8, this);
        }

        private void Lvl3_Click(object sender, EventArgs e)
        {
            myController.SelectDifficulty(16, this);
        }
    }
}
