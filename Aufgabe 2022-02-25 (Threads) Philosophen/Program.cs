using Aufgabe_2022_02_25__Threads__Philosophen;

class Programm
{
    static void Main()
    {
    
        Gabel Gabel1 = new Gabel();
        Gabel Gabel2 = new Gabel();
        Gabel Gabel3 = new Gabel();
        Gabel Gabel4 = new Gabel();
        Gabel Gabel5 = new Gabel();


        Philosoph nietzsche = new Philosoph("Nietzsche", Gabel1, Gabel2);
        Philosoph schopenhauer = new Philosoph("Schopenhauer", Gabel2, Gabel3);
        Philosoph engels = new Philosoph("Engels", Gabel3, Gabel4);
        Philosoph kant = new Philosoph("Kant", Gabel4, Gabel5);
        Philosoph descartes = new Philosoph("Descartes", Gabel5, Gabel1);

        Thread threadp1 = new (nietzsche.Essen);
        Thread threadp2 = new (schopenhauer.Essen);
        Thread threadp3 = new (engels.Essen);
        Thread threadp4 = new (kant.Essen);
        Thread threadp5 = new (descartes.Essen);

        threadp1.Start();
        threadp2.Start();
        threadp3.Start();
        threadp4.Start();
        threadp5.Start();
    }
}