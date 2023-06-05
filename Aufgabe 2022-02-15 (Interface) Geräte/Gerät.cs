using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Geräte
{
    internal class Gerät
    {
        private string name;
        private bool status;

        public Gerät(string name)
        {
            this.name = name;
            this.status = false;
        }

        public string Name { get { return name; } set { name = value; } }
        public bool Status { get { return status; } set { status = value; } }

        public bool Anschalten()
        {
            if (status != true)
            {
                status = true;
                Console.WriteLine("Gerät angeschaltet");
            }
            else
            {
                Console.WriteLine("Gerät ist bereits angeschaltet");
            }
            return status;
        }
        public bool Ausschalten()
        {
            if (status != false)
            {
                status = false;
                Console.WriteLine("Gerät ausgeschaltet");                
            }
            else
            {
                Console.WriteLine("Gerät ist bereits ausgeschaltet");
            }
            return status;
        }
    }
}
