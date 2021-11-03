using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurSensor_Doliv.Tools
{
    public class Logs
    {
        public void LogWrite(string logMessage)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Log(logMessage, w);
            }
        }

        public void LogWrite(string Title,string logMessage)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Log(Title,logMessage, w);
            }
        }

        public void LogWriteBlock(string logMessage)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                LogInOneBlock(logMessage, w);
            }
        }

        public void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        public void Log(string logTitle, string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine($"  :{logTitle}");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        public void LogInOneBlock(string logMessage, TextWriter w)
        {
            //w.Write("\r\nLog Entry : ");
            //w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            //w.WriteLine($"  :{logTitle}");
            w.WriteLine($"{logMessage}");
            //w.WriteLine("-------------------------------");
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        // The example creates a file named "log.txt" and writes the following lines to it,
        // or appends them to the existing "log.txt" file:

        // Log Entry : <current long time string> <current long date string>
        //  :
        //  :Test1
        // -------------------------------

        // Log Entry : <current long time string> <current long date string>
        //  :
        //  :Test2
        // -------------------------------

        // It then writes the contents of "log.txt" to the console.
    }
}
