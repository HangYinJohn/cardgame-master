using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGameNewVersion
{
    public class Model
    {
        public Deck theDeck;
        public int selectedIndex;

        public Model()
        {
            selectedIndex = -1;
        }

        public void display(PictureBox CardNumber, char CardName)
        {
        }

        public Deck AssignDeck()
        {
            return theDeck = new Deck();
        }

        public void SelectCard(int index)
        {
            selectedIndex = index;
        }

        public Card SelectedCard()
        {
            return theDeck.FindCard(selectedIndex);
        }

        public Boolean CardsMatch(Card aCard)
        {
            return (SelectedCard().Flip() == aCard.Flip());
        }

        public Boolean checkWon()
        {
            Boolean result = true;
            foreach(Card aCard in theDeck.allMyCards)
            {
            if(aCard.HasWon() == false)
            {
                result = false;
            }
            }
            
            return result;
        }
    }
}
