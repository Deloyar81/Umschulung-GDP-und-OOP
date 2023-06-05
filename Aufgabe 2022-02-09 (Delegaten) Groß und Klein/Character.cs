using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_09__Delegaten__Groß_und_Klein
{
    delegate void CharacterDelegate(string wort);
    class Character
    {
        public void UpperCase(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        public void LowerCase(string text)
        {
            Console.WriteLine(text.ToLower());
        }

        public void UpperLower(string text)
        {
            Console.WriteLine(text);
        }
    }
}
