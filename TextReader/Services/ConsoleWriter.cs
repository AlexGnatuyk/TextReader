using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextReader.Interfaces;
using TextReader.Services;

namespace TextReader
{
    public class ConsoleWriter : IWrite
    {
        private readonly IAwersomeTextReader reader;

        public ConsoleWriter(IAwersomeTextReader reader)
        {
            this.reader = reader;
        }

             

        public void Write()
        {
            Console.WriteLine(reader.Read());
            
        }

        
    }
}
