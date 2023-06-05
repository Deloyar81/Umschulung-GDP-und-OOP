using Aufgabe_2022_02_15__Interface__Nachrichten;

Person person1 = new Person("Harald");
Person person2 = new Person("Simone");

Vermittler v1 = new Vermittler();

Radio radio1 = new Radio();
Webseite webseite1 = new Webseite();

v1.Anmelden(person1);



Console.ReadKey();