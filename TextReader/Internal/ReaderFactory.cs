﻿using System;


namespace TextReader.Internal
{
    internal class ReaderFactory:IReaderFactory
    {
        public ITextReader Create(Uri uri)
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
