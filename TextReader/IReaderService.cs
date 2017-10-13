using System;

namespace TextReader
{
    public interface IReaderService
    {
        ITextReader Create(Uri uri);
    }
}
