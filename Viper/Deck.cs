using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viper
{
    internal class Deck
    {
        private Card[] Cards;

        public Deck(string filename)
        {
            // Load fronts and backs of cards from file,
            // then instantiate Card objects in Cards
            string fileContent = Properties.Resources.Deck1;
            string[] strings = fileContent.Split('\n');
            Cards = new Card[strings.Length];
            for (int i=0; i <strings.Length; i++)
            {
                Cards[i] = new Card(strings[i]);
            }

            // TEMPORARY DEBUG BEHAVIOR
            /*
            foreach (Card card in Cards)
            {
                card.messageBoxDebug();
            }
            */
        }
    }
}
