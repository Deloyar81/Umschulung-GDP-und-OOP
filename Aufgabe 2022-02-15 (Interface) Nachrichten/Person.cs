using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Nachrichten
{
    internal class Person : INachrichtenEmpfänger
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }
        public string Name { get { return name; } set { name = value; } }


        public void EmpfangeNachricht(string nachricht)
        {
            
        }
    }
}
