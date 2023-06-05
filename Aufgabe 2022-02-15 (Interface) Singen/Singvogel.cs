using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Singen
{
    internal class Singvogel : ISingen
    {
        public void Singen()
        {
            Console.WriteLine("Flapflap");
            Console.WriteLine("ZwitscherZwitscher");
        }
    }
}
