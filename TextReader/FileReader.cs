using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextReader.Interfaces;

namespace TextReader
{
    public class FileReader:IAwersomeTextReader,IWrite
    {
        public static string Read()
        {
            string data = System.IO.File.ReadAllText(@"C:\Users\st044618\Source\Repos\TextReader\TextReader\Data.txt");
            return data;
        }

        string IAwersomeTextReader.Read()
        {
            return Read();
        }

        public void Write()
        {
            string content = Read();
            Console.WriteLine(content);
            Console.Read();

            //throw new NotImplementedException();
        }
    }
}
