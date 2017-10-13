using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace TextReader
{
    class WriterService : IWriterService
    {
        ReaderService readerService;
        private ConsoleWriter writer;
        

        public WriterService(ReaderService readerService)
        {
            this.readerService = readerService;
            
        }

        public ITextWriter Create(Uri uri)
        {
            var reader = readerService.Create(uri);
            writer = new ConsoleWriter(reader);
            
            return writer;
        }

        public ITextWriter Create()
        {
            throw new NotImplementedException();
        }
    }
}
