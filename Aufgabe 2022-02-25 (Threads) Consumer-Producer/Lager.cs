using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_25__Threads__Consumer_Producer
{
    internal class Lager
    {
        object lockObject = new object();
        private int bestand;
        private const int limit = 1000;

        public Lager(int bestand)
        {
            this.bestand = bestand;
        }

        public int GetBestand { get { return bestand; } }
        public int GetLimit { get { return limit; } }

        Random random = new Random();
        public void Entnehmen()
        {
            while (true)
            {
                try
                {
                    Monitor.Enter(lockObject);

                    int entnehmen = random.Next(1, 101);

                    if (bestand - entnehmen < 0) { Monitor.Wait(lockObject); }
                    else
                    {
                        Monitor.Pulse(lockObject);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Entnommen: {0, 3}, ", entnehmen);

                        bestand -= entnehmen;
                        if (bestand < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" ***Warnung***");
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("Neuer Bestand: {0, 4}", bestand);
                        Console.ResetColor();
                        Thread.Sleep(100);
                    }
                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
            }
        }

            public void Produzieren()
        {
            while (true)
            {
                try
                {
                    Monitor.Enter(lockObject);
                    int produzieren = random.Next(1, 101);
                    
                    if (bestand + produzieren > limit) { Monitor.Wait(lockObject); }
                    Monitor.Pulse(lockObject);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Produziert: {0, 3}, ", produzieren);
                    bestand += produzieren;
                    if (bestand > limit)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ***Warnung***");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                Console.WriteLine("Neuer Bestand: {0, 4}", bestand);
                    Console.ResetColor();
                    Thread.Sleep(100);

                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
            }
        }
    }
}
