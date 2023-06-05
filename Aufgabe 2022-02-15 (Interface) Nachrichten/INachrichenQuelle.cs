using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_15__Interface__Nachrichten
{
    internal interface INachrichenQuelle
    {
        // Interessierte können sich bei der Quelle anmelden 
        // (falls sie noch nicht angemeldet sind) 
        void Anmelden(INachrichtenEmpfänger empfänger);

        // Angemeldete können sich bei der Quelle wieder abmelden 
        // (falls sie angemeldet sind) 
        void Abmelden(INachrichtenEmpfänger empfänger);

        // neue Nachricht wird an alle angemeldeten Empfänger übergeben 
        // (Aufruf deren Methode EmpfangeNachricht) 
        void SendeNachricht(string nachricht);

    }
}
