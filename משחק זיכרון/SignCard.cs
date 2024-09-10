using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class SignCard : BaseCard
    {
        public char Sign { get; set; }
        public string Color { get; set; }
        public SignCard(char sign, string color)
        {
            this.Sign = sign;
            this.Color = color;
        }
        public override bool IsEquals(BaseCard other)
        {
            if (other is SignCard)
            {
                if (this.Sign == (other as SignCard).Sign)
                    return true;
            }
            return false;
        }

        public override void DrewCard()
        {
            Console.WriteLine("--");
            Console.WriteLine("| " + this.Sign + " |");
            Console.WriteLine("--");
        }

    }
}
