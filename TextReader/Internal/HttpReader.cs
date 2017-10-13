using System;
using System.Net;


namespace TextReader
{
    internal class HttpReader:ITextReader
    {
        //private readonly DataSourceOptions source;
        // public HttpReader(DataSourceOptions source)
        // {
        //     this.source = source;
        // }

        public Uri uri { get; set; }
        public string Read()
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
