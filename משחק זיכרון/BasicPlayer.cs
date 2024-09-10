using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal abstract class BasicPlayer
    {
        public int Points { get; set; }
        public BaseCard[] GuesCard { get; set; }
        public BasicPlayer()
        {
            GuesCard = new BaseCard[8];
        }
        public string Name { get; set; }
        public abstract void SETNAME();
        public abstract int[] ChooseCard(int n);


    }
}
