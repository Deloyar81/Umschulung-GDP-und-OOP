using Aufgabe_2022_02_18__Delegates__Logger;

//Variablen
string logpfad = @"D:\logdatei.txt";

Output delegateLoggerOutput = new Output(logpfad);
Logger logger = new Logger(logpfad);

Dellogger write = new Dellogger(logger.Write); ;
Dellogger ausgabe = new Dellogger(delegateLoggerOutput.Ausgabe);
//Dellogger close = new Dellogger(logger.Close);

Dellogger kombi = write + ausgabe;

//Stream
kombi("Hier ist ein Text...");

Console.ReadKey();