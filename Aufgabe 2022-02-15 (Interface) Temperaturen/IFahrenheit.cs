using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Temperaturen
{
    internal interface IFahrenheit
    {
     
        double Fahrenheit { get; set; }
        //double Fahrenheit { get => Fahrenheit = Celsius * 9 / 5 + 32; set { Fahrenheit = (Celsius - 32) * 5 / 9; } }

        void ToString();
    }
}
