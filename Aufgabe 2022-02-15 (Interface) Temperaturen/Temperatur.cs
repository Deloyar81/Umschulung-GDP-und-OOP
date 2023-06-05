using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Temperaturen
{
    internal class Temperatur : ICelsius, IFahrenheit, IKelvin
    {
        private double temperatur;

        public Temperatur(double temperatur)
        {
            this.temperatur = temperatur;
            Celsius = temperatur;
        }

        public double Fahrenheit { get => Celsius * 9 / 5 + 32; set => Celsius = (Fahrenheit - 32) * 5 / 9;  }

        public double Celsius { get => temperatur ; set { temperatur = value; } }
        public double Kelvin { get => Celsius + 273.15; set { Celsius = Kelvin -273.15; } }


        public void ToString()
        {
            Console.WriteLine("Celsius: {0}", Celsius);
            Console.WriteLine("Fahrenheit: {0}", Fahrenheit);
            Console.WriteLine("Kelvin: {0}", Kelvin);
        }

    }
}
