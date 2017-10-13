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
        ReaderService readerService;
        private ConsoleWriter writer;
        

        public WriterService(ReaderService readerService)
        {
            this.readerService = readerService;
            
        }

        public ConsoleWriter Create(Uri uri)
        {
            var reader = readerService.CreateReader(uri);
            writer = new ConsoleWriter(reader);
            
            return writer;
        }

        

        
    }
}
