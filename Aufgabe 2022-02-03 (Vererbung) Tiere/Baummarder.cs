using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_03__Vererbung__Tiere
{
    public class Baummarder : Tier
    {
        public Baummarder(double aktuellesGewicht) : base(aktuellesGewicht) { }

        protected override bool CanEat(Tier tier)
        {
            if (tier is Eichhoernchen && this.GetIsAlive == true && tier.GetIsAlive == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
