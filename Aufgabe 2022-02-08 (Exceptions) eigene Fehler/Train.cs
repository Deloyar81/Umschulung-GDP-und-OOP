using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_08__Exceptions__eigene_Fehler
{
    internal class Train
    {
        private string zugnummer;
        private int wagenanzahl;
        private int kilometer;

        public Train(string zugnummer, int wagenanzahl, int kilometer)
        {
            this.zugnummer = zugnummer;
            this.wagenanzahl = wagenanzahl;
            this.kilometer = kilometer;
        }

        public string Zugnummer
        { get { return zugnummer; } set { zugnummer = value; } }

        public int Wagenanzahl
        { get { return wagenanzahl; } set { wagenanzahl = value;} }
    
        public int Kilometer
        { get { return kilometer; } set { kilometer = value; } }
    }
}
