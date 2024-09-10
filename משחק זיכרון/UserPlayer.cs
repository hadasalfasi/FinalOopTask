using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class UserPlayer : BasicPlayer
    {
        public override void SETNAME()
        {
            Console.WriteLine("enter your name: \n");
            this.Name = Console.ReadLine();
        }
        public override int[] ChooseCard(int n)
        {
            int[] arr = new int[2];
            do
            {
                Console.WriteLine("which place do you choose? between 0 to " + n + "\n");
                arr[0] = int.Parse(Console.ReadLine());
                arr[1] = int.Parse(Console.ReadLine());
            }
            while (arr[0] > n||arr[0]<0 || arr[1] < 0 || arr[1] > n);

            return arr;
        }
    }
}
