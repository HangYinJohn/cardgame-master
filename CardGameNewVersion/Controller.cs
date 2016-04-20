using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace CardGameNewVersion
{
    public class Controller
    {
        
        
        public Model myModel;
        public IView myView;
        public Deck myDeck;
        protected Boolean firstPlayerTurn;
        Assembly _assembly;
        StreamReader _textStreamReader;
        public Controller(IView theView, Model theModel)
        {
            myView = theView;
            myModel = theModel;
            myDeck = myModel.AssignDeck();
        }

        public void Go()
        {
            myDeck.Unlock();        

        }

        public void Close(Form form)
        {
            form.Close();
        }

        public void SelectDifficulty(int index, Form difficultyMenu)
        {
            difficultyMenu.Hide();
            myDeck.LoadDeck(parseCardNames(), index);
            myDeck.ShuffleDeck();
            if (index == 4)
            {
                myView = new GameLevelEasy();
            }
            else if (index == 8)
            {
                myView = new GameLevelMedium();
            }
            else
            {
                myView = new GameLevelDifficult();
            }
            firstPlayerTurn = true;
            myView.ChangeTurn(firstPlayerTurn);
            SetController();
            myView.ShowDialog();
        }

        public List<string> parseCardNames()
        {
            List<string> result = LoadFromFile("PokemonList");
            int length = result.Count;
            result.RemoveAt(0);
            return result;
        }

        public List<string> LoadFromFile(string name)
        {
            List<string> result = new List<string>();
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                String fileName = @"CardGameNewVersion." + name + @".txt";
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(fileName));
                using (_textStreamReader)
                {
                    while (_textStreamReader.Peek() >= 0)
                    {
                        result.Add(_textStreamReader.ReadLine());
                    }
                };
                return result;
            }
            catch (Exception e)   
            {
                MessageBox.Show(e.GetType().ToString());
                return null;
            }

        }

        public void CardsSelected(string folder, Form startMenu)
        {
            myDeck.SetImageDirectory(folder);
            Difficulty theView = new Difficulty();
            theView.SetController(this);
            startMenu.Hide();
            theView.ShowDialog();
        }

        public void SwipeChoice()
        {
            myView.SlashBarMove();
            myDeck.Unlock();
            ChangeTurn();
            myView.ChangeTurn(firstPlayerTurn);
        }

        public void ChangeTurn()
        {
            if (firstPlayerTurn)
            {
                firstPlayerTurn = false;
            }
            else
            {
                firstPlayerTurn = true;
            }
        }

        public void SetController()
        {
            myView.SetController(this);
        }

        public void clickProcess(ref System.Windows.Forms.PictureBox choice, int index)
        {
            if (!myDeck.CheckLock())
            {
                myDeck.Lock();
                Card aCard = myDeck.FindCard(index);
                string myCard = aCard.Flip();
                myView.ChangeImage(ref choice, myCard);
                checkMatch(aCard, index);
                WinGame(myView);
            }
            
        }

        public void WinGame(IView theWindow)
        {
            VictoryScreen victory = new VictoryScreen();
            if (myModel.checkWon())
            {
                theWindow.Dispose();
                victory.Show();
            }            
        }
        public void checkMatch(Card aCard, int index)
        {            
                if (myModel.selectedIndex != -1)
                {
                    waitTime(500);
                        if (myModel.CardsMatch(aCard))
                        {
                            myView.PlaySound();
                            aCard.Discard();
                            myView.DiscardBox(myView.FindPic(index));
                            myModel.SelectedCard().Discard();
                            myView.DiscardBox(myView.FindPic(myModel.selectedIndex));
                        }
                        else
                        {
                            System.Windows.Forms.PictureBox choice = myView.FindPic(myModel.selectedIndex);
                            myView.ChangeImage(ref choice, myModel.SelectedCard().Hide());
                            myModel.SelectCard(index);
                        }                    
                }
            else 
            {
                myModel.SelectCard(index);
            }
            
        }
        public void waitTime(int waitTime)
        {
            DateTime waitTimer = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (waitTimer.AddMilliseconds(waitTime) > DateTime.Now);
        }        
    }
}
