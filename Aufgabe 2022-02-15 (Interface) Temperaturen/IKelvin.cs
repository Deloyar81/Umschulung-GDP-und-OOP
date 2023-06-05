using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Temperaturen
{
    internal interface IKelvin : ICelsius
    {
        double Kelvin { get; set; }
        void ToString();
    }
}
