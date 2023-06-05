using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_25__Threads__Philosophen
{
    internal class Gabel
    {
        private bool benutzt;

        public Gabel()
        {
            benutzt = false;
        }

        public void GabelNehmen()
        {
            this.benutzt = true;
        }

        public void GabelAblegen()
        {
            this.benutzt = false;
        }

        public bool Benutzt { get { return benutzt; } }
    }
}
