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
        //private readonly IAwersomeTextReader reader;

        //public ConsoleWriter(IAwersomeTextReader reader)
        //{
        //    this.reader = reader;
        //}

        private ReaderService readerService;

        internal ConsoleWriter(ReaderService readerService)
        {
            this.readerService = readerService;
        }

        public void Write()
        {
            //var content = reader.Read();
            Console.WriteLine(readerService);
            
        }

        
    }
}
