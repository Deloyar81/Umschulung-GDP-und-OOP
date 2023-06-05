using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Geräte
{
    internal class Kombigerät : Gerät, Drucken, Senden
    {
        public Kombigerät(string name) : base(name)
        {
            this.Name = name;
        }
        public bool Drucken(string text)
        {
            try
            {
                if (Status == true)
                {
                    Console.WriteLine("{0} druckt: {1}", Name, text);
                }
                else
                {
                    throw new GeräteException("Das Gerät ist ausgeschaltet");
                }
            }
            catch (GeräteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Status;
        }

        public bool Senden(string text)
        {
            try
            {
                if (Status == true)
                {
                    Console.WriteLine("{0} sendet: {2}", Name, text);                
                }
                else
                {
                    throw new GeräteException("Das Gerät ist ausgeschaltet");
                }             
            }
            catch (GeräteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Status;
        }
    }
}
