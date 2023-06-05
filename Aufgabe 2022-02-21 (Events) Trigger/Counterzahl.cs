using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_21__Events__Trigger
{
    public delegate void Counterhandler(int x);
    class Counterzahl
    {
        private int count;
        private int limit;

        Func<int, int, bool> Bedingung = (count, limit) =>
        {
            if (count <= limit) return true;
            return false;
        };

        public Counterzahl(int x) => count = x;
        
        
        public void ZählerstandErhöhren(int x)
        {
            if(x + count >= limit) 
            {
                Console.WriteLine();
                Console.WriteLine("Der maximale Zählerstand ist errreicht bzw. kann nicht überschritten werden: {0}", limit);
                Console.WriteLine("Der aktuelle Zählerstand ist: {0}", count);
                Console.WriteLine("Der Zählerstand kann nur noch um {0} eröht werden",limit - count);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Der alte Zählerstand ist: {0}", count);
                Console.WriteLine("Sie wollen {0} hinzufügen", x);
                count += x;
                Ausgabe(count);
            } 
        }

        public void Clear()
        {
            Console.WriteLine("Der maximale Zählerstand ist errreicht: {0}", count);
            count = 0;
        }

        public void SetLimit(int x)
        {
            limit = x;
        }
        public void Ausgabe(int x)
        {
            Console.WriteLine("Der aktuelle Zählerstand ist: {0}", count);
        }

        public event Counterhandler bedingung;
        public event Counterhandler aktion;
    }
}
