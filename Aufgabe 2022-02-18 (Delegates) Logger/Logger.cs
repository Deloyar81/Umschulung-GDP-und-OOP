using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_18__Delegates__Logger
{


    internal class Logger
    {
        //private string logtext;
        private string logpfad;
        private FileStream logstream;
        private StreamWriter logwriter;



        public Logger(string logpfad)
        {
            this.logpfad = logpfad;
        }

        public void Write(string logtext)
        {
            logstream = new FileStream(logpfad, FileMode.Append, FileAccess.Write);
            logwriter = new StreamWriter(logstream);
            logwriter.WriteLine(logtext);
            Close();
        }

        public void Close()
        {
            if (logwriter != null)
            {
                logwriter.Close();
            }
        }

    }
}
