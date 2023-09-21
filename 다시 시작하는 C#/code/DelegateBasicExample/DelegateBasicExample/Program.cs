using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBasicExample
{
    delegate void LogDel(string text);
    internal class Program
    {
        static void Main(string[] args)
        {
            //델리게이트는 
            Log log = new Log();
            //LogDel logdel = new LogDel(log.LogTextFile);

            LogDel LogTextToScreen, LogTextFile;
            LogTextToScreen = new LogDel(log.LogTextToScreen);
            LogTextFile = new LogDel(log.LogTextFile);

            LogDel mulitiLogDel = LogTextToScreen + LogTextFile;
            Console.WriteLine("이름을 입력해주세요: ");
            var name = Console.ReadLine();

            mulitiLogDel(name);
            //logdel(name);
            LogText(LogTextFile, name);
            Console.ReadKey();

        }
        static void LogText(LogDel logDel, string text)
        {
          //  logDel(text);
        }


        
    }
        public class Log
        {

            public void LogTextToScreen(string text)
            {
                Console.WriteLine($"{DateTime.Now}: {text}");
            }
            public void LogTextFile(string text)
            {
                    using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt"), true))
                    {
                        sw.WriteLine($"{DateTime.Now}: {text}");
                    }
            }
        }
}
