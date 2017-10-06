using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextReader.Interfaces;

namespace TextReader
{
    class ConsoleWriter:IWrite
    {
        public void Write(string content)
        {
            Console.Write(content);
            Console.Read();
        }
    }
}
