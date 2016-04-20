using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CardGameNewVersion
{
    public partial class GameLevelDifficult : Form, IView
    {
        Boolean firstPlayerTurn;
        Controller myController;
        List<PictureBox> cards = new List<PictureBox>();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public GameLevelDifficult()
        {
            InitializeComponent();
        }

        public void ChangeTurn(Boolean turn)
        {
            firstPlayerTurn = turn;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            cards.Add(Card1);
            cards.Add(Card2);
            cards.Add(Card3);
            cards.Add(Card4);
            cards.Add(Card5);
            cards.Add(Card6);
            cards.Add(Card7);
            cards.Add(Card8);
            cards.Add(Card9);
            cards.Add(Card10);
            cards.Add(Card11);
            cards.Add(Card12);
            cards.Add(Card13);
            cards.Add(Card14);
            cards.Add(Card15);
            cards.Add(Card16);      
            player.SoundLocation = (Path.GetDirectoryName(Environment.CurrentDirectory) + @"\..\..\images\matchCheer.wav");
            player.Load();
        }

        public void PlaySound()
        {
            player.Play();
        }

        public void SetController(Controller theController)
        {
            myController = theController;
        }

        public void ChangeImage(ref System.Windows.Forms.PictureBox choice, string image)
        {
            Bitmap bitmap = new Bitmap(@image);
            choice.Image = bitmap;
            choice.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void SlashBarMove()
        {

            if (firstPlayerTurn)
            {
                int n;
                for (n = 0; n < 970; n++)
                {
                    myController.waitTime(1);
                    SwipeBar.Location = new Point(n + 1, SwipeBar.Location.Y);                    
                }
            }
            else
            {
                int n;
                for (n = 0; n < 970; n++)
                {
                    myController.waitTime(1);
                    SwipeBar.Location = new Point(SwipeBar.Location.X - 1, SwipeBar.Location.Y);                    
                }
            }
        }

        private void SwipeBar_Click(object sender, EventArgs e)
        {
            myController.SwipeChoice();
        }

        
        private void ExitButton_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Card1_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card1, 0);
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card2, 1);
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card3, 2);
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card4, 3);
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card5, 4);
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card6, 5);
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card7, 6);
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card8, 7);
        }

        private void Card9_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card9, 8);
        }

        private void Card10_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card10, 9);
        }

        private void Card11_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card11, 10);
        }

        private void Card12_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card12, 11);
        }

        private void Card13_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card13, 12);
        }

        private void Card14_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card14, 13);
        }

        private void Card15_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card15, 14);
        }

        private void Card16_Click(object sender, EventArgs e)
        {
            myController.clickProcess(ref Card16, 15);
        }

        public PictureBox FindPic(int index)
        {
            return cards[index];
        }

        public void DiscardBox(PictureBox Choice)
        {
            Choice.Visible = false;
        }
    }
}
