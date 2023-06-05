using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_18__Events__Warpkern
{
    public delegate void WarpkernTemperaturÄnderungsHandler(int temperaturalt, int temperaturneu);
    internal class Warpkern
    {
        private int warpkernTemperatur;

        public Warpkern(int warpkernTemperatur)
        {
            this.warpkernTemperatur = warpkernTemperatur;
        }
        public int WarpkernTemperatur 
        { 
            get { return warpkernTemperatur; }
            set 
            { 
                if(warpkernTemperatur == value) { return; }
                if(value > 500)
                {
                    warpkernTemperaturÄnderungsHandler2(warpkernTemperatur, value);
                    warpkernTemperatur = value;
                }
                else
                {
                    warpkernTemperaturÄnderungsHandler(warpkernTemperatur, value);
                    warpkernTemperatur = value;
                }
            } 
        }

        public int Temperaturneu(int randomtemp)
        {
            return warpkernTemperatur = randomtemp;
        }

        public event WarpkernTemperaturÄnderungsHandler warpkernTemperaturÄnderungsHandler;
        public event WarpkernTemperaturÄnderungsHandler warpkernTemperaturÄnderungsHandler2;
    }
}
