using Aufgabe_2022_02_21__Events__Trigger;

Counterzahl counter1 = new Counterzahl(0);


counter1.aktion += counter1.Ausgabe;
counter1.SetLimit(1000);


counter1.ZählerstandErhöhren(100);
counter1.ZählerstandErhöhren(850);
counter1.ZählerstandErhöhren(300);

Counterhandler bedingung = counter1.SetLimit;
bedingung(1200);

counter1.Clear();

counter1.ZählerstandErhöhren(100);
counter1.ZählerstandErhöhren(850);
counter1.ZählerstandErhöhren(300);

Console.ReadLine();

