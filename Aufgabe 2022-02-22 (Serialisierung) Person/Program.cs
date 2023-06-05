using Aufgabe_2022_02_22__Serialisierung__Person;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap; //existiert nur bis .NET 4.8?
using System.Xml.Serialization;
using System.IO;


List<Person> person = new();

Person ehepartner1 = new ("Albert", "Einstein", Convert.ToDateTime("05.12.1942"));
Person ehepartner2 = new("Karl", "Lauterbach", Convert.ToDateTime("12.07.1978"));
Person ehe1opa1 = new("Dolph", "Lundgren", Convert.ToDateTime("12.08.1962"));
Person ehe1oma1 = new("Captain", "Janeway", Convert.ToDateTime("12.08.1962"));
Person ehe2opa2 = new("Sylvester", "Stallone", Convert.ToDateTime("12.08.1962"));
Person ehe2oma2 = new("Mariah", "Carey", Convert.ToDateTime("12.08.1962"));
Person kind = new("Marie", "Curie", Convert.ToDateTime("03.12.1872"));

//ehepartner1.Mutter = ehe1oma1;
//ehepartner1.Vater = ehe1opa1;
//ehepartner1.Ehepartner = ehepartner2;
//ehepartner1.Kind = kind;
//ehepartner2.Mutter = ehe2oma2;
//ehepartner2.Vater = ehe2opa2;
//ehepartner2.Ehepartner = ehepartner1;
//ehepartner2.Kind = kind;
//kind.Mutter = ehepartner1;
//kind.Vater = ehepartner2;
//ehe1oma1.Ehepartner = ehe1opa1;
//ehe1opa1.Ehepartner = ehe1oma1;
//ehe2oma2.Ehepartner = ehe2opa2;
//ehe2opa2.Ehepartner = ehe2oma2;

person.Add(ehepartner1);
person.Add(ehepartner2);
person.Add(kind);
person.Add(ehe1opa1);
person.Add(ehe1oma1);
person.Add(ehe2opa2);
person.Add(ehe2oma2);

//Ausgabe der Gesamten Liste
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Ausgabe aller Personen");
Console.ResetColor();
foreach (Person p in person)
{
    p.AusgabePerson();
}

//Serialisierung der Liste
BFPersonSerializelist();

//Deserialisierung und Ausgabe der Liste
BFPersonDeserializelist();

//Datei löschen
File.Delete(@"D:\Person.dat");

//Serialisierung von 2 Personen BF
BFPersonSerialize();

//Deserialisierung und Ausagbe von 2 Personen BF
BFPersonDeserialize();

//Serialisierung von 2 Personen XmL
XmLPersonSerialize();

//Deserialisierung und Ausagbe von Liste Personen XmL
XmLPersonDeserialize();

void BFPersonSerialize()
{
    BinaryFormatter bf1 = new();

    FileStream fileStream = new(@"D:\Person.dat", FileMode.OpenOrCreate);

    //foreach (Person p in person)
    //{
    //    bf1.Serialize(fileStream, p);
    //}

    bf1.Serialize(fileStream, ehepartner1);
    bf1.Serialize(fileStream, ehe2oma2);

    fileStream.Close();
}

void BFPersonSerializelist()
{
    BinaryFormatter bf2 = new();

    FileStream fileStream = new(@"D:\Person.dat", FileMode.OpenOrCreate);

    bf2.Serialize(fileStream, person);

    fileStream.Close();
}

void BFPersonDeserializelist()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Ausgabe der deserialisierten Personen ");
    Console.ResetColor();

    BinaryFormatter bf2 = new();

    FileStream fileStream = new(@"D:\Person.dat", FileMode.Open);

    List<Person> liste = new((List<Person>)bf2.Deserialize(fileStream));

    foreach(Person p in liste)
    {
        p.AusgabePerson();
    }
    fileStream.Close();
}

void BFPersonDeserialize()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Ausgabe von 2 Personen BF");
    Console.ResetColor();

    BinaryFormatter bf1 = new();

    FileStream fileStream = new(@"D:\Person.dat", FileMode.Open);

    Person p1 = (Person)bf1.Deserialize(fileStream);
    Person p2 = (Person)bf1.Deserialize(fileStream);

    p1.AusgabePerson();
    p2.AusgabePerson();

    fileStream.Close();
}

//existiert nur bis 4.8?
//void SOAPPersonSerializelist()
//{
//    SoapFormatter soap1 = new();

//    FileStream fileStream = new(@"D:\Person.dat", FileMode.OpenOrCreate);

//    soap1.Serialize(fileStream, person);

//    fileStream.Close();
//}

void XmLPersonSerialize()
{
    XmlSerializer xml1 = new(typeof(List<Person>));

    FileStream xmlfileStream1 = new(@"D:\Person.xml", FileMode.Create);
    xml1.Serialize(xmlfileStream1, person);

    xmlfileStream1.Close();
}

void XmLPersonDeserialize()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Ausgabe von allen Personen XmL");
    Console.ResetColor();

    XmlSerializer xml2 = new(typeof(List<Person>));

    FileStream xmlfileStream2 = new(@"D:\Person.xml", FileMode.Open);

    List<Person> p1_xml = (List<Person>)xml2.Deserialize(xmlfileStream2);

    foreach (Person p in p1_xml)
    {
        p.AusgabePerson();
    }

    xmlfileStream2.Close();
}

Console.ReadLine();