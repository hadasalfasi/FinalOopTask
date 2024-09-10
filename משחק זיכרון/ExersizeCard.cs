using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class ExersizeCard:BaseCard
    {
        
        public string exersize { get; set; }
        public string solve { get; set; }
        public ExersizeCard(string exersize, string solve)
        {
            this.exersize = exersize;
            this.solve = solve;
        }

        public override bool IsEquals(BaseCard other)
        {
            if (other is ExersizeCard)
            {
                if (this.exersize .Equals( (other as ExersizeCard).exersize)&&this.solve.Equals( (other as ExersizeCard).solve))
                    return true;
            }
            return false;
        }

        public override void DrewCard()
        {
            if (this.IsFirst)
            {
                Console.WriteLine("--");
                Console.WriteLine("| " + this.exersize + " |");
                Console.WriteLine("--");
            }
            else
            {
                Console.WriteLine("--");
                Console.WriteLine("| " + this.solve + " |");
                Console.WriteLine("--");
            }
           
        }
    }
}
