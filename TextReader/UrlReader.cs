using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TextReader.Interfaces;

namespace TextReader
{
    public class UrlReader:IAwersomeTextReader,IWrite
    {
        static string url = "https://timetable.spbu.ru/api/v1/addresses?seating=0&capacity=15";

        private static string Read()
        {
            string ResponseText = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                ResponseText = response.StatusCode.ToString();
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                ResponseText = "Такой страницы нет.";
            }
            response.Close();
            return ResponseText;
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
