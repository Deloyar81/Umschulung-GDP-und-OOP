using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_02__Polymorphie__Devices
{
    class AudioDevice : Device
    {
        private string typangabe;

        public AudioDevice(int nummer, string herstellerangabe, string typangabe) : base(nummer, herstellerangabe)
        {
            this.typangabe = typangabe;
        }

        public override string ToString()
        {
            return base.ToString() +
                    "\nTypangabe: " + typangabe;
        }
    }
}
