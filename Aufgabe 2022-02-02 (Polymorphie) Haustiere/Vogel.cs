using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_02__Polymorphie__Haustiere
{
    internal class Vogel : Haustier
    {
        private bool singvogel;

        public Vogel(string name, double jahreskostenTierarzt, bool singvogel) : base(name, false, jahreskostenTierarzt)
        {
            this.singvogel = singvogel;
        }

        public bool Singvogel { get { return singvogel; } }

        public new string GetBeschreibung()
        {
            return base.GetBeschreibung() + 
                    "Singvogel: " + Singvogel;
        }
    }
}
