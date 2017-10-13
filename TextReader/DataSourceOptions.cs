using System;

namespace TextReader
{
    public class DataSourceOptions
    {
        public Uri urlSource { get; set; }

        public Uri ReturUri()
        {
            return urlSource;
        }
    }
}
