using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viper
{
    internal class Card
    {
        private string Front;
        private string Back;

        public Card(string fields)
        {
            string[] strings = fields.Split(',');
            Front = strings[0];
            Back = strings[1];
        }

        public bool tryAnswer(string answer)
        {
            return answer.Equals(Back);
        }

        // TEMPORARY DEBUG BEHAVIOR
        public void messageBoxDebug()
        {
            MessageBox.Show($"Front: {Front}\nBack: {Back}", "Card", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
