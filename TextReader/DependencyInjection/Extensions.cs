using System;
using Autofac;
using TextReader.Internal;


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
            builder.RegisterType<ConsoleWriter>().As<ITextWriter>();
            builder.RegisterType<HttpReader>().As<ITextReader>();

            

            return builder;
        }

        public static ContainerBuilder RegisterFileReaderServices(this ContainerBuilder builder)
        {
            var url = new DataSourceOptions
            {
                urlSource = new Uri("file://C:/Users/st044618/Source/Repos/TextReader/TextReader/Data.txt")
            };
            builder.RegisterInstance(url);

            builder.RegisterType<ConsoleWriter>().As<ITextWriter>();
            builder.RegisterType<FileReader>().As<ITextReader>();
            
            return builder;
        }

        public static ContainerBuilder RegisterServices(this ContainerBuilder builder)
        {
            builder.RegisterType<ReaderFactory>().As<IReaderFactory>();
            builder.RegisterType<WriterFactory>().As<IWriterFactory>();

            return builder;
        }
    }
}
