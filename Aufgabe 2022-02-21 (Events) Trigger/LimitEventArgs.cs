using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_21__Events__Trigger
{
    public class LimitEventArgs

    {
        private int limit;
        public int Limit { get { return limit; } set { limit = value; } }

        public LimitEventArgs(int limit)
        {
            this.limit = limit;
        }
    }
}
