using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_03__Vererbung__Tiere
{
    public class Eichhoernchen : Tier
    {
        public Eichhoernchen(double aktuellesGewicht) : base(aktuellesGewicht) { }

        protected override bool CanEat(Tier tier) => false;
     

    }
}
