using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Geräte
{
    internal class GeräteException : Exception
    {
        string message;

        public GeräteException(string message)
        {
            this.message = message;
        }

        public override string Message
        { get { return message; } }
    }
}
