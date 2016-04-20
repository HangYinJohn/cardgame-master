using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CardGameNewVersion
{
    public class Deck
    {
        string imageDirectory;
        public List<Card> allMyCards;
        Boolean isLocked;
        public Deck()
        {
            allMyCards = new List<Card>();
            imageDirectory = Path.GetDirectoryName(Environment.CurrentDirectory) + @"\..\..\images\";
        }

        public Boolean CheckLock()
        {
            return isLocked;
        }

        public void SetImageDirectory(string folder)
        {
            imageDirectory = Path.GetDirectoryName(Environment.CurrentDirectory) + @"\..\..\images\"+folder+@"\";
        }

        public void Lock()
        {
            isLocked = true;
        }

        public void Unlock()
        {
            isLocked = false;
        }

        public Card FindCard(int index)
        {
            return allMyCards[index];
        }

        public void LoadDeck(List<string> items, int index)
        {
            int n;
            List<int> randomList = SetRandom(items.Count);
            for (n = 0; n < index/2; n++)
            {
                AddCard(items[randomList[n]]);
                AddCard(items[randomList[n]]);
            }
        }

        public void ShuffleDeck()
        {
            int n;
            List<int> randomList = SetRandom(allMyCards.Count);
            List<Card> tempArray = new List<Card>();
            for (n = 0; n < allMyCards.Count; n++)
            {
                tempArray.Add(allMyCards[randomList[n]]);

            }
            for (n = 0; n < tempArray.Count; n++)
            {
                allMyCards[n] = tempArray[n];
            }
        }

        public List<int> SetRandom(int index)
        {
            DeckRandom random = new DeckRandom(index);
            random.Set();
            return random.Get();
        }

        public void AddCard(string newImage)
        {
            Card card = new Card(imageDirectory + @"\..\card0.png" , imageDirectory + newImage);
            allMyCards.Add(card);
        }
    }
}
