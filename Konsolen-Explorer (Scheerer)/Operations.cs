using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolen_Explorer__Scheerer_
{
    internal class Operations
    {
        DirectoryInfo[] directories;
        FileInfo[] files;
        public string Path { get; set; }

        public void ListDirectory()
        {
            DirectoryInfo di = new DirectoryInfo(Path);



            // Alle Verzeichnisse im aktuellen Verzeichnis im Array speichern
            directories = di.GetDirectories();

            // Alle Dateien im aktuellen Verzeichnis im Array speichern
            files = di.GetFiles();

            // Konsole löschen
            Console.Clear();

            // aktuellen Pfad ausgeben
            Console.WriteLine(Path);
            Console.WriteLine();

            // Wechsel in übergeordneten Ordner anzeigen
            Console.Write(" 0 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("dir ");
            Console.ResetColor();
            Console.Write("..");
            Console.WriteLine();

            // Alle Verzeichnisse anzeigen
            for (int i = 0; i < directories.Length; i++)
            {
                Console.Write("{0,2} ", i + 1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("dir ");
                Console.ResetColor();
                Console.Write("{0}", directories[i].Name);
                Console.WriteLine();
            }

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine("{0,2} {1}", i + directories.Length + 1, files[i].Name);
            }
            Console.WriteLine();
            Console.Write("Auswahl: ");


        }

        public void ChangeDirectory(int index)
        {
            if (index == 0 && Path != "c:\\")
            {


                Path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
                Directory.SetCurrentDirectory(Path);
                ListDirectory();


            }
            else
            {


                if (index - 1 < 0)
                    return;
                Path = directories[index - 1].FullName;
                Directory.SetCurrentDirectory(Path);
                ListDirectory();


            }
        }
    }
}
