using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
