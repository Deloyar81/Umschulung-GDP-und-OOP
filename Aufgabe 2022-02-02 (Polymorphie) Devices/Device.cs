using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_02__Polymorphie__Devices
{
    public class Device
    {
        protected int nummer;
        protected string herstellerangabe;

        public Device(int nummer, string herstellerangabe)
        {
            this.nummer = nummer;
            this.herstellerangabe = herstellerangabe;
        }

        public virtual string ToString()
        {
            return "Nummer: " + nummer +
                    "\nHerstellerangabe: " + herstellerangabe;
        }

    }
}
