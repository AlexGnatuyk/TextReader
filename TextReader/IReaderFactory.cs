using System;

namespace TextReader
{
    public interface IReaderFactory
    {
        ITextReader Create(Uri uri);
    }
}
