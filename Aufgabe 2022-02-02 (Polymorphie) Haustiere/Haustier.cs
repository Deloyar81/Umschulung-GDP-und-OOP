using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_02__Polymorphie__Haustiere
{
    abstract class Haustier
    {
        protected string name;
        protected bool steuerpflichtig;
        protected double jahreskostenTierarzt;

        public string GetName { get { return name; } }

        public bool IsSteuerpflichtig { get { return steuerpflichtig; } }

        public double JahreskostenTierarzt { get { return jahreskostenTierarzt;} }

        public Haustier(string name, bool steuerpflichtig, double jahreskostenTierarzt)
        {
            this.name = name;
            this.steuerpflichtig = steuerpflichtig;
            this.jahreskostenTierarzt = jahreskostenTierarzt;
        }

        public string GetBeschreibung()
        {
            return "Name: " + name +
                   "\nSteuerpflichtig: " + steuerpflichtig;
        }
    }
}
