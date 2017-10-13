using System;


namespace TextReader
{
    internal class ConsoleWriter : ITextWriter
    {
        private readonly ITextReader reader;

        public ConsoleWriter(ITextReader reader)
        {
            this.reader = reader;
        }

             

        public void Write()
        {
            Console.WriteLine(reader.Read());
            
        }

        
    }
}
