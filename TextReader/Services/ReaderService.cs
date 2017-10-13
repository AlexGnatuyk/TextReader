using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TextReader.Interfaces;

namespace TextReader.Services
{
    class ReaderService
    {
        public IAwersomeTextReader CreateReader(Uri uri)
        {
            string prevSymb = uri.ToString().Substring(0, 1);
            if (prevSymb == "f")
            {
                FileReader reader = new FileReader
                {
                    uri = uri
                };
                return reader;
            }
            if (prevSymb == "h")
            {
                HttpReader reader = new HttpReader
                {
                    uri = uri
                };
               return reader;
            }
            return null;
        }
    }
    
}
