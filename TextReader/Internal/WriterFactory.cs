using System;

namespace TextReader.Internal
{
    internal class WriterFactory : IWriterFactory
    {
        readonly IReaderFactory readerService;
        private ConsoleWriter writer;
        

        public WriterFactory(IReaderFactory readerService)
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
