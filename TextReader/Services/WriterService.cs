using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextReader.Services
{
    class WriterService
    {
        private ReaderService readerService;
        private ConsoleWriter writer;

        public WriterService(ReaderService readerService)
        {
            this.readerService = readerService;
            writer = new ConsoleWriter();
        }

        public void Create()
        {
            
        }

        public void WriteFile()
        {
            var urlSource = new Uri("file://C:/Users/st044618/Source/Repos/TextReader/TextReader/Data.txt");
            writer.Write(readerService.CreateReader(urlSource));
        }

        public void WriteHttp()
        {
            var urlSource = new Uri("https://timetable.spbu.ru/api/v1/addresses?seating=0&capacity=15");
            writer.Write(readerService.CreateReader(urlSource));
        }
    }
}
