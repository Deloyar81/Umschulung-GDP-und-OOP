using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_01_31__Vererbung__Auto
{
    internal class Auto
    {
        protected string kennzeichen = "DO-OM 3";
        protected float kilometerstand = 0;
        protected int sitzplaetze = 5;
        protected bool antenne = true;

        public Auto(string kennzeichen, int sitzplaetze)
        {
            this.kennzeichen = kennzeichen.ToUpper();
            this.sitzplaetze = sitzplaetze;
        }

        public Auto(string kennzeichen)
        {
            this.kennzeichen = kennzeichen;
        }
        public Auto(int sitzplaetze)
        {
            this.sitzplaetze = sitzplaetze;
        }

        public Auto()
        { 
        }

        public string Kennzeichen { get { return kennzeichen;} }
        public float Kilometerstand { get { return kilometerstand;} }
        public int Sitzplaetze { get { return sitzplaetze;} }
        public bool Antenne { get { return antenne;} }

        public string GetKennzeichen()
        {
            return kennzeichen;
        }

        public float GetKilometerstand()
        {
            return kilometerstand;
        }

        public void Fahre(int x)
        {
            Console.WriteLine("Das Auto hat {0} Kilometer auf der letzten Fahrt zurück gelegt.");
            kilometerstand = kilometerstand + x;
        }
        public void AntenneEinfahren()
        {
            Console.WriteLine("Die Antenne wird eingefahren");
            Thread.Sleep(2000);
            Console.WriteLine("Die Antenne ist eingefahren");
            antenne = false;
        }
        public void AntenneAusfahren()
        {
            Console.WriteLine("Die Antenne wird ausgefahren");
            Thread.Sleep(2000);
            Console.WriteLine("Die Antenne ist ausngefahren");
            antenne = true;
        }
        public bool IstAntenneDraussen()
        {
            return antenne;
        }

        public void VorDemWaschen()
        {
            if (antenne == true)
            {
                AntenneEinfahren();
            }
            else
            {
                Console.WriteLine("Antenne ist bereits eingefahren.");
            }

        }

        public void Waschen()
        {
            VorDemWaschen();
            Console.WriteLine("Das Auto wird jetzt gewaschen");
        }

        public int GetSitzplaetze()
        {
            return sitzplaetze;
        }

        public string ToString()
        {
            string auto;

            return auto =   "Auto-Kennzeichen: " + GetKennzeichen() +
                            "\nKilometerstand: " + GetKilometerstand() +
                            "\nAnzahl Sitzplätze: " + GetSitzplaetze() +
                            "\nIst Antenne ausgefahren? " + IstAntenneDraussen();
        }
    }
}
