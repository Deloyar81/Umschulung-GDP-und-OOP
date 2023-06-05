using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_01_28__Vererbung__Gehaltsabrechnung
{
    public class Abteilungen : Mitarbeiter
    {
        protected string abteilung;
        protected double grundgehalt;

        public Abteilungen(string vorname, string nachname, string x) : base(vorname, nachname)
        {
            switch (x)
            {
                case "Vertrieb":
                    this.abteilung = "A";
                    this.grundgehalt = 820;
                    break;

                case "Entwicklung":
                    this.abteilung = "B";
                    this.grundgehalt = 710;
                    break;

                case "Produktion":
                    this.abteilung = "C";
                    this.grundgehalt = 935;
                    break;

                default:
                    throw new ArgumentException();

            }
        }
    }



}
