using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_18__Delegates__Logger
{
    delegate void Dellogger(string text);
    internal class Output
    {
        private string logpfad;

        public Output(string logpfad)
        {
            this.logpfad = logpfad;
        }
        public void Ausgabe(string logtext)
        {
            Console.Write(File.ReadAllText(logpfad, Encoding.UTF8));
        }

    }
}
