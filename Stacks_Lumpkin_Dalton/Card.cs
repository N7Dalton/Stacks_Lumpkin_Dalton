using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Lumpkin_Dalton
{
    //Card class
    class Card
    {
        //string
        public string Num { get; }
        //anotha string
        public string Suit { get; }
        //card thiny
        public Card(string numParam, string suitParam)
        {
            Num = numParam;
            Suit = suitParam;
        }
    }
}
