using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextReader.Interfaces;

namespace TextReader
{
    public class ConsoleWriter:IWrite
    {
        public static void Write(string content)
        {
            Console.WriteLine(content);
            Console.Read();
        }

        void IWrite.Write(string content)
        {
            Write(content);
        }
    }
}
