using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using TextReader.Interfaces;

namespace TextReader
{
    public class HttpReader:IAwersomeTextReader
    {
       //private readonly DataSourceOptions source;
       // public HttpReader(DataSourceOptions source)
       // {
       //     this.source = source;
       // }

        public string Read(Uri uri)
        {
            string ResponseText = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
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

        
    }
}
