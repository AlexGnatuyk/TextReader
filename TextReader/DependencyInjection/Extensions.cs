using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TextReader.Interfaces;
using TextReader.Services;

namespace TextReader.DependencyInjection
{
    public static class Extensions
    {
        public static ContainerBuilder RegisterUrlReaderServices(this ContainerBuilder builder)
        {
            var url = new DataSourceOptions
            {
                urlSource = new Uri("https://timetable.spbu.ru/api/v1/addresses?seating=0&capacity=15")
            };

            builder.RegisterInstance(url);
            builder.RegisterType<ConsoleWriter>().As<IWrite>();
            builder.RegisterType<HttpReader>().As<IAwersomeTextReader>();

            

            return builder;
        }

        public static ContainerBuilder RegisterFileReaderServices(this ContainerBuilder builder)
        {
            var url = new DataSourceOptions
            {
                urlSource = new Uri("file://C:/Users/st044618/Source/Repos/TextReader/TextReader/Data.txt")
            };
            builder.RegisterInstance(url);

            builder.RegisterType<ConsoleWriter>().As<IWrite>();
            builder.RegisterType<FileReader>().As<IAwersomeTextReader>();
            
            return builder;
        }

        public static ContainerBuilder RegisterServices(this ContainerBuilder builder)
        {
            builder.RegisterType<ReaderService>();
            builder.RegisterType<WriterService>();

            return builder;
        }
    }
}
