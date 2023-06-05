using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_03__Vererbung__Tiere
{
    public class Uhu : Tier
    {

        public Uhu(double aktuellesGewicht) : base(aktuellesGewicht) { }

        protected override bool CanEat(Tier tier)
        {
            //return GetIsAlive && tier.GetIsAlive && 

            if ((tier is Eichhoernchen || tier is Baummarder) && this.GetIsAlive == true && tier.GetIsAlive == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Fliegen()
        {
            if ( this.GetAktuellesGewicht > this.GetInitialGewicht + 10)
            {
                aktuellesGewicht -= 10;
            }
        }
    }
}
