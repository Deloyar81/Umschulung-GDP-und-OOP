using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_08__Exceptions__eigene_Fehler
{
    internal class RailwayStationException : Exception
    {
        string message;

        public RailwayStationException(string message)
        {
            this.message = message;
        }

        public override string Message
        { get { return message; } }
    }
}
