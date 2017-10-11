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
        public static string Read()
        {
            Uri uriAddress = new Uri("file://C:/Users/st044618/Source/Repos/TextReader/TextReader/Data.txt");
            string data = System.IO.File.ReadAllText(uriAddress.LocalPath);
            return data;
        }

        string IAwersomeTextReader.Read()
        {
            return Read();
        }
        
    }
}
