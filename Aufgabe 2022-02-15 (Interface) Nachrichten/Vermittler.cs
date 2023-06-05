using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Nachrichten
{
    internal class Vermittler : INachrichenQuelle, INachrichtenEmpfänger
    {
        public void Abmelden(INachrichtenEmpfänger empfänger)
        {
            Console.WriteLine("{0} hat sich abgemeldet", empfänger.GetType().Name);
        }

        public void Anmelden(INachrichtenEmpfänger empfänger)
        {
            Console.WriteLine("{0} hat sich angemeldet", empfänger.GetType().Name);
        }

        public void EmpfangeNachricht(string nachricht)
        {
            Console.WriteLine(nachricht);
        }

        public void SendeNachricht(string nachricht)
        {
            Console.WriteLine(nachricht);
        }
    }
}
