using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_02__Polymorphie__Devices
{
    internal class VideoDevice : Device
    {
        private int formatangabe;

        public VideoDevice(int nummer, string herstellerangabe, int formatangabe): base(nummer,herstellerangabe)
        {
            this.formatangabe = formatangabe;
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nFormatangabe: " + formatangabe;                            
        }
    }
}
