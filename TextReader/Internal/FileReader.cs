using System;


namespace TextReader
{
    internal class FileReader:ITextReader
    {
        //private readonly DataSourceOptions URL;
        //public FileReader(DataSourceOptions URL)
        //{
        //    this.URL = URL;
        //}

        public Uri uri { get; set; }
        public string Read()
        {
            string data = System.IO.File.ReadAllText(uri.LocalPath);
            return data;
        }

                
    }
}
