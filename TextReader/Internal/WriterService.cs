using System;

namespace TextReader.Internal
{
    internal class WriterService : IWriterService
    {
        readonly IReaderService readerService;
        private ConsoleWriter writer;
        

        public WriterService(IReaderService readerService)
        {
            this.readerService = readerService;
            
        }

        public ITextWriter Create(Uri uri)
        {
            var reader = readerService.Create(uri);
            writer = new ConsoleWriter(reader);
            
            return writer;
        }

    }
}
