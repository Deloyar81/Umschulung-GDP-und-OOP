using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_08__Exceptions__eigene_Fehler
{
    internal class RailwayStation
    {
        private string bahnhofname;
        private int fassungsvermögengesamt;
        private int fassungsvermögenaktuell;

        private List<Train> trains = new List<Train>();

        public RailwayStation(string bahnhofname)
        {
            this.bahnhofname = bahnhofname;
            this.fassungsvermögengesamt = 100;
            this.fassungsvermögenaktuell = 0;

        }
        public List<Train> Trains
        { get { return trains; } }

        public string Bahnhofname
        { get { return bahnhofname; } }

        public int Fassungsvermögengesamt
        { get { return fassungsvermögengesamt; } }

        public int Fassungsvermögenaktuell
        { get { return fassungsvermögenaktuell; } }

        public void Ausgabe()
        {
            Console.WriteLine();
            foreach (Train t in trains)
            {
                Console.WriteLine("Im Bahnhof steht der Zug mit der Nummer: {0}",t.Zugnummer.ToString());
            }
        }

        public void AddZug(Train train)
        {
            Console.WriteLine();
            try
            {
                
                Console.WriteLine("Der Zug mit der Nummer {0} will in den Bahnhof {1} einfahren", train.Zugnummer, Bahnhofname);
                if (fassungsvermögenaktuell <= fassungsvermögengesamt - train.Wagenanzahl)
                {
                    Console.WriteLine("Der Zug mit der Nummer {0} darf in den Bahnhof {1} einfahren", train.Zugnummer, Bahnhofname);
                    trains.Add(train);
                    fassungsvermögenaktuell += train.Wagenanzahl;
                }
                else
                {
                    throw new RailwayStationException("Der Bahnhof " + Bahnhofname + " kann keine weiteren Waggons fassen!");
                }
            }
            catch (RailwayStationException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void SubZug()
        {
            try
            {
                if (trains.Count > 0)
                {
                    Console.WriteLine("Der Zug mit der Zugnummer {0} verlässt den Bahnhof {1}.", trains[0].Zugnummer, Bahnhofname);
                    trains.Remove(trains[0]);
                }
                else
                {
                    throw new RailwayStationException("Im Bahnhof " + Bahnhofname + " stehen keine Züge, die diesen verlassen könnten!");
                }
            }
            catch (RailwayStationException e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
