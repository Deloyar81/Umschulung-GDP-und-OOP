using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_01_28__Vererbung__Gehaltsabrechnung
{
    public class Tarif : Mitarbeiter
    {
        protected string tarif;
        protected double grundgehalt;

        public Tarif(string vorname, string nachname, string x) : base(vorname, nachname)
        {
            switch (x)
            {
                case "A":
                    this.tarif = "A";
                    this.grundgehalt = 2560;
                    break;

                case "B":
                    this.tarif = "B";
                    this.grundgehalt = 3000;
                    break;

                case "C":
                    this.tarif = "C";
                    this.grundgehalt = 3200;
                    break;

                case "D":
                    this.tarif = "D";
                    this.grundgehalt = 5400;
                    break;

                default:
                    throw new ArgumentException();

            }
        }
    }



}

