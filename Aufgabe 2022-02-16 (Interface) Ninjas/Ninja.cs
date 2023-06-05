using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Ninjas
{
    internal class Ninja
    {
        private string waffe;

        public Ninja(string waffe)
        {
            this.waffe = waffe.ToLower();
        }

        public Ninja()
        {
            this.waffe = "";
        }

        Schwert schwert = new();
        Shuriken shuriken = new();

        public void Angreifen(string gegner)
        {
            if (waffe == "schwert")
            {
                schwert.GegnerTreffen(gegner);
            }
            else if (waffe == "shuriken")
            {
                shuriken.GegnerTreffen(gegner);
            }
            else if(waffe == "")
            {
                Console.WriteLine("Was für ein  {0}. Du hast keine Waffe... und im Unterricht für 'Waffenlosen Kampf' gefehlt. Dein Gegner sticht dich einfach ab.", GetType().Name);
            }
        }


    }
}
