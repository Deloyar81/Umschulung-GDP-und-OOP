using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_02__Polymorphie__Haustiere
{
    internal class Katze : Haustier
    {
        private Vogel lieblingsVogel;

        public Katze(string name, double jahreskostenTierarzt, Vogel vogel) : base(name, false, jahreskostenTierarzt)
        {
            this.lieblingsVogel = vogel;
        }

        public string GetVogelName()
        {
            return lieblingsVogel.GetName;
        }

        public new string GetBeschreibung()
        {
            return base.GetBeschreibung() +
                    "Lieblingsvogel: " + lieblingsVogel;
        }

        public void neuerLieblingsvogel(Vogel vogel)
        {
            this.lieblingsVogel = vogel;
        }
    }
}
