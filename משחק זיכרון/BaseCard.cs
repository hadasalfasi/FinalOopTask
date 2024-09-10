using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal abstract class BaseCard
    {
        public bool Cover { get; set; }
        public bool IsChoosen { get; set; }

        public BaseCard()
        {
            this.IsChoosen = false;
            this.Cover = false;
        }
        public bool IsFirst { get; set; }
        public abstract bool IsEquals(BaseCard other);
        public abstract void DrewCard();
    }
}
