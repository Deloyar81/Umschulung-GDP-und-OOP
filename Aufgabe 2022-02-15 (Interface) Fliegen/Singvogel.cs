using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Fliegen
{
    internal class Singvogel : ISingen, IFliegen
    {

        public void Fliegen()
        {
            Console.WriteLine("Flapflap");
        }
        public void Singen()
        {
            Console.WriteLine("Zwitscherzwitscher");
        }
    }
}
