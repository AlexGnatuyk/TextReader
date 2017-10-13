using System;

namespace TextReader
{
    public interface IWriterService
    {
        ITextWriter Create(Uri uri);
    }
}
