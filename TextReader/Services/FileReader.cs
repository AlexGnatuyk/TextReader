using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextReader.Interfaces;

namespace TextReader
{
    public class FileReader:IAwersomeTextReader
    {
        private readonly DataSourceOptions URL;
        public FileReader(DataSourceOptions URL)
        {
            this.URL = URL;
        }
        
        public string Read()
        {
            string data = System.IO.File.ReadAllText(URL.urlSource.LocalPath);
            return data;
        }

        string IAwersomeTextReader.Read()
        {
            return Read();
        }
        
    }
}
