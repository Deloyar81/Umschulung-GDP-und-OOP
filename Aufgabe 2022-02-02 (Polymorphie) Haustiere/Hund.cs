using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_02__Polymorphie__Haustiere
{
    internal class Hund : Haustier
    {
        private string rasse;

        public Hund(string name, double jahreskostenTierarzt, string rasse) : base(name, true, jahreskostenTierarzt)
        {
            this.rasse = rasse;
        }

        public string Rasse { get { return rasse; } }

        public new string GetBeschreibung()
        {
            return  base.GetBeschreibung() + 
                    "\nRasse: " + Rasse;
        }
    }
}
