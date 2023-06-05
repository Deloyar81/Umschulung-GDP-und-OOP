using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_01_31__Vererbung__Auto
{
    internal class Pickup : Auto
    {
        protected int fassungsvermoegen;
        protected int ladung = 0;
        protected new int sitzplaetze = 2;

        public Pickup(string kennzeichen, float kilometerstand, int sitzplaetze, int fassungsvermoegen) : base(kennzeichen)
        {
            this.fassungsvermoegen = fassungsvermoegen;

        }

        public bool Beladen(int x)
        {
            if(ladung+x <= fassungsvermoegen)
            {
                ladung += x;
                Console.WriteLine("Beladung erfolgreich");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Entladen(int x)
        {
            if (ladung >= x)
            {
                ladung -= x;
                Console.WriteLine("Entladung erfolgreich");
                return true;
            }
            else
            {
                return false;
            }
        }

        public new void VorDemWaschen()
        {
            base.VorDemWaschen();
            ladung = 0;
        }

        public int GetLadung()
        {
            return ladung;
        }

        public new string ToString()
        {
            string pickup, ausgabe;

            pickup =    "\nLadefläche: " + fassungsvermoegen +
                        "\nLadung: " + GetLadung();

            return ausgabe = string.Concat(base.ToString() + pickup);

        }
    }
}
