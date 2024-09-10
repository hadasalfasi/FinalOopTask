using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class ComputerPlayer : BasicPlayer
    { 
        public override void SETNAME()
        {
            this.Name = "computer";
        }
        public override int[] ChooseCard(int n)
        {
            Random random = new Random();
            int[] arr = new int[2];
            Console.WriteLine( "now the computer play");
            arr[0] = random.Next(n);
            arr[1] = random.Next(n);
            
            return arr;
        }

    }
}
