using Aufgabe_2022_02_15__Interface__Geräte;

Faxgerät faxgerät = new Faxgerät("Fax1000");
Kombigerät kombigerät = new Kombigerät("Kombi2000");
Laserdrucker laserdrucker = new Laserdrucker("Laserover9000");

faxgerät.Anschalten();
faxgerät.Senden("blabla feiner text");
faxgerät.Ausschalten();

kombigerät.Drucken("blabla feiner text");
kombigerät.Anschalten();
kombigerät.Drucken("blabla feiner text");


Console.ReadKey();  