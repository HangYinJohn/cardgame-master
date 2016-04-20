using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CardGameNewVersion
{
    public interface IView
    {
        void ChangeImage(ref System.Windows.Forms.PictureBox choice, string image);
        void SetController(Controller theController);
        void SlashBarMove();
        void ChangeTurn(Boolean Turn);
        void PlaySound();
        PictureBox FindPic(int index);
        void DiscardBox(PictureBox Choice);
        DialogResult ShowDialog();
        void Dispose();
    }
}
