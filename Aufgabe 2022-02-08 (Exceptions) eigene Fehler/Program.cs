using Aufgabe_2022_02_08__Exceptions__eigene_Fehler;

//Trains initialisieren
Train train1 = new Train("1", 40, 25);
Train train2 = new Train("2", 25, 10);
Train train3 = new Train("3", 25, 10);
Train train4 = new Train("4", 25, 10);

//Bahnhof initialisieren
RailwayStation BHF = new RailwayStation("Hammerthal");



BHF.AddZug(train1);
BHF.AddZug(train2);
BHF.AddZug(train3);
BHF.AddZug(train4);

BHF.Ausgabe();

BHF.SubZug();

BHF.Ausgabe();

BHF.SubZug();
BHF.SubZug();
BHF.SubZug();



Console.ReadKey();