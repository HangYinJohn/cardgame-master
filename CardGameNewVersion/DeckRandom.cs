using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameNewVersion
{
    class DeckRandom
    {
        protected List<int> myOrder;
        protected int deckSize;

        public DeckRandom(int newDeckSize)
        {
            deckSize = newDeckSize;
        }

        public void Set()
        {
            Random random = new Random();
            List<int> result = new List<int>();
            List<int> list = new List<int>();
            int n;
            for (n=0; n < deckSize; n++) {
                list.Add(n);
            }
            
            for (n = 0; n < deckSize; n++)
            {
                int count = list.Count();
                int temp = random.Next(0, count);
                result.Add(list[temp]);
                list.RemoveAt(temp);
            }

            myOrder = result;
        }

        public List<int> Get()
        {
            return myOrder;
        }
    }
}
