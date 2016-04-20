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
    public partial class GameLevelEasy : Form, IView
    {
        Controller myController;
        Boolean firstPlayerTurn;
        List<PictureBox> cards = new List<PictureBox>();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public GameLevelEasy()
        {
            InitializeComponent();
        }

        private void GameLevelEasy_Load(object sender, EventArgs e)
        {
            cards.Add(Card1);
            cards.Add(Card2);
            cards.Add(Card3);
            cards.Add(Card4);
            player.SoundLocation = (Path.GetDirectoryName(Environment.CurrentDirectory) + @"\..\..\sounds\matchCheer.wav");
            player.Load();
        }

        public void PlaySound()
        {
            player.Play();
        }

        public void ChangeTurn(Boolean turn)
        {
            firstPlayerTurn = turn;
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

        private void ExitButton_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
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
