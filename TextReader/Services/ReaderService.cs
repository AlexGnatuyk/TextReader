using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TextReader.Services
{
    class ReaderService
    {
        public string CreateReader(Uri uri)
        {
            string prevSymb = uri.ToString().Substring(0, 1);
            if (prevSymb == "f")
            {
                FileReader reader = new FileReader();
                return reader.Read(uri);
            }
            if (prevSymb == "h")
            {
               HttpReader reader = new HttpReader();
                return reader.Read(uri);
            }
            return "Error";
        }
    }
    
}
