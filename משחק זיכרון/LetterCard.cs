using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class LetterCard:BaseCard
    {
        public char Letter { get; set; }
        public LetterCard(char letter)
        {
            this.Letter = letter;
        }
        public override bool IsEquals(BaseCard other)
        {
            if (other is LetterCard)
            {
                if (this.Letter == (other as LetterCard).Letter)
                    return true;
            }
            return false;
        }

        public override void DrewCard()
        {
            Console.WriteLine("--");
            Console.WriteLine("| " + this.Letter + " |");
            Console.WriteLine("--");
        }
    }
}
