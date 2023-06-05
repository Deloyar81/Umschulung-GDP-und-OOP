using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_22__Serialisierung__Person
{
    [Serializable]
    public class Person : IDeserializationCallback
    {
        private string nachname;
        private string vorname;
        [NonSerialized]
        private int alter;
        private DateTime gdatum;
        private Person vater;
        private Person mutter;
        private Person ehepartner;
        private Person kind;

        public string Nachname { get { return nachname; } set { nachname = value; } }
        public string Vorname { get { return vorname; } set { vorname = value; } }
        public int Alter { get { return alter; } set { alter = value; } }
        public DateTime Gdatum { get { return gdatum; } set { gdatum = value; } }
        public Person Vater { get { return vater; } set { vater = value; } }
        public Person Mutter { get { return mutter; } set { mutter = value; } }
        public Person Ehepartner { get { return ehepartner; } set { ehepartner = value; } }
        public Person Kind { get { return kind; } set { kind = value; } }

        //Konstruktor Person
        public Person(string vorname, string nachname, DateTime gdatum)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.gdatum = gdatum;
            this.alter = DateTime.Now.Year - gdatum.Year;
        }

        public Person()
        {
        }

        //Methode 1 zur Widerherstellung des Alters nach der Deserialisierung
        [OnDeserialized]
        public void ALterNeuBerechnen(StreamingContext sc)
        {
            this.alter = DateTime.Now.Year - gdatum.Year;
        }

        public void AusgabePerson()
        {
            Console.WriteLine("Nachname: {0}",Nachname);
            Console.WriteLine("Vorname: {0}",Vorname);
            Console.WriteLine("Alter: {0}", Alter);
            Console.WriteLine("Geburtsdatum: {0}", Gdatum.ToString("d"));
            if (vater != null)
                Console.WriteLine("Vater: {0}", Vater.vorname + " " + Vater.nachname);
            if (mutter != null)
                Console.WriteLine("Mutter: {0}", Mutter.vorname + " " + Mutter.nachname);
            if (ehepartner != null)
                Console.WriteLine("Ehepartner: {0}", Ehepartner.vorname + " " + Ehepartner.nachname);
            if (kind != null)
                Console.WriteLine("Kind: {0}", Kind.vorname + " " + Kind.nachname);
            Console.WriteLine();
        }

        public int GetAgeFromDate(DateTime birthday)
        {
            int years = DateTime.Now.Year - birthday.Year;
            birthday = birthday.AddYears(years);
            if (DateTime.Now.CompareTo(birthday) < 0) { years--; }
            return years;
        }

        //Methode 2 zur Wiederherstellung des Alters nach der Deserialiserung
        public void OnDeserialization(object? sender)
        {
            this.alter = DateTime.Now.Year - gdatum.Year;
        }
    }
}

