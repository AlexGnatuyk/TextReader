using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextReader.Services
{
    class WriterService
    {
        private ReaderService readerService;
        private ConsoleWriter writer;
        private Uri urlSource;

        public WriterService(ReaderService readerService)
        {
            this.readerService = readerService;
            writer = new ConsoleWriter();
        }

        public void Create(Uri uri)
        {
            string prevSymb = uri.ToString().Substring(0, 1);
            if (prevSymb == "f")
            {
                urlSource = new Uri(uri.ToString());
            }
            if (prevSymb == "h")
            {
                urlSource= new Uri(uri.ToString());
            }
        }

        public void Write()
        {
            writer.Write(readerService.CreateReader(urlSource));
        }

        
    }
}
