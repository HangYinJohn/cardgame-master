using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameNewVersion
{
    public class Card
    {
        string image;
        string hiddenImage;
        Boolean discarded;

        public Card(string newHiddenImage, string newImage) 
        {
            image = newImage;
            hiddenImage = newHiddenImage;
            discarded = false;
        }

        public string Flip()
        {
            return image;
        }

        public string Hide()
        {
            return hiddenImage;
        }

        public void Discard()
        {
            discarded = true;
        }

        public Boolean HasWon()
        {
            return discarded;
        }
    }
}
