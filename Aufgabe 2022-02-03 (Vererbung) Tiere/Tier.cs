using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aufgabe_2022_02_03__Vererbung__Tiere
{
    public abstract class Tier
    {
        protected double aktuellesGewicht;
        private double initialGewicht;
        private bool isAlive;

        public double GetAktuellesGewicht { get { if (isAlive == true) { return aktuellesGewicht; } else { return 0; } } }
        public double GetInitialGewicht { get { return initialGewicht; } }
        public bool GetIsAlive { get { return isAlive; } }

        public Tier(double aktuellesGewicht)
        {
            this.isAlive = true;
            this.aktuellesGewicht = aktuellesGewicht;
            this.initialGewicht = aktuellesGewicht;
        }

        protected abstract bool CanEat(Tier tier);

        public void WirdGetoetet()
        {
            isAlive = false;
        }

        public void Eat(Tier tier)
        {
            if (CanEat(tier) == true)
            {
                aktuellesGewicht += tier.aktuellesGewicht;
                tier.WirdGetoetet();

                Console.WriteLine("{0} hat {1} gefressen und freut sich über einen vollen Magen", this.GetType().Name, tier.GetType().Name);
                Console.WriteLine("{0} hat ein aktuelles Gewicht von: {1}", this.GetType().Name, this.GetAktuellesGewicht);
            }
        }

        public void Verdauen()
        {
            if(aktuellesGewicht > initialGewicht)
            {
                aktuellesGewicht = (aktuellesGewicht - initialGewicht) * 0.05 + initialGewicht;
            }
        }

    }
}