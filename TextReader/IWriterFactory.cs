using System;

namespace TextReader
{
    public interface IWriterFactory
    {
        ITextWriter Create(Uri uri);
    }
}
