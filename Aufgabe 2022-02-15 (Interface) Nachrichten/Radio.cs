using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Nachrichten
{
    internal class Radio : INachrichenQuelle
    {
        List<INachrichtenEmpfänger> listEmpfänger = new();
        public void Anmelden(INachrichtenEmpfänger empfänger)
        {
            listEmpfänger.Add(empfänger);
            Console.WriteLine("{0} hat sich angemeldet", empfänger.GetType().Name);
        }
        public void Abmelden(INachrichtenEmpfänger empfänger)
        {
            listEmpfänger.Remove(empfänger);
            Console.WriteLine("{0} hat sich abgemeldet", empfänger.GetType().Name);
        }

        public void SendeNachricht(string nachricht)
        {
            foreach(INachrichtenEmpfänger emp in listEmpfänger)
            {
                emp.EmpfangeNachricht(nachricht);
            }
        }

    }
}
