using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viper
{
    internal class Card
    {
        private string Front;
        private string Back;

        public Card(string front, string back)
        {
            Front = front;
            Back = back;
        }

        public bool tryAnswer(string answer)
        {
            return answer.Equals(Back);
        }
    }
}
