using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_25__Threads__Philosophen
{
    internal class Philosoph
    {
        object essen = new object();
        Random random = new Random();
        bool status = false;

        private string name;
        private Gabel gabelLinks;
        private Gabel gabelRechts;

        public Philosoph(string name, Gabel links, Gabel rechts)
        {
            this.name = name;
            this.gabelLinks = links;
            this.gabelRechts = rechts;
        }


        public void Methode1()
        {
            if (gabelLinks.Benutzt == false && gabelRechts.Benutzt == false)
            {
                status = false;
                gabelLinks.GabelNehmen();
                gabelRechts.GabelNehmen();
                Console.WriteLine("Der Philosoph {0} futtert Spaghetti!", name);
                Monitor.Wait(essen, random.Next(100, 501));
                gabelLinks.GabelAblegen();
                gabelRechts.GabelAblegen();

                Console.WriteLine("Der Philosoph {0} hat aufgegessen und geht Nachdenken!", name);
                Thread.Sleep(random.Next(100, 501));
                Console.WriteLine("Der Philosoph {0} bekommt Hunger und hört auf nachzudenken!", name);
            }
            else
            {
                if(status == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Philosph {0} muss warten!", name);
                    Console.ResetColor();
                    status = true;
                }
                
            }
        }

        public void Methode2()
        {
            if (gabelLinks.Benutzt == true && gabelRechts.Benutzt == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Philosph {0} muss warten!", name);
                Console.ResetColor();

            }
            else
            {
                gabelLinks.GabelNehmen();
                gabelRechts.GabelNehmen();
                Console.WriteLine("Der Philosoph {0} futtert Spaghetti!", name);
                Monitor.Wait(essen, random.Next(100, 501));
                gabelLinks.GabelAblegen();
                gabelRechts.GabelAblegen();

                Console.WriteLine("Der Philosoph {0} hat aufgegessen und geht Nachdenken!", name);
                Thread.Sleep(random.Next(100, 501));

            }
        }

        public void Essen()
        {
            while (true)
            {
                try
                {
                    Monitor.Enter(essen);
                    Methode1();
                    //Methode2();


                }
                finally
                {
                    Monitor.Exit(essen);
                }
            }

        }
    }
}
