using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TextReader.Interfaces;

namespace TextReader.DependencyInjection
{
    public static class Extensions
    {
        public static ContainerBuilder RegisterUrlReaderServices(this ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleWriter>().As<IWrite>();
            builder.RegisterType<UrlReader>().As<IAwersomeTextReader>();
            

            return builder;
        }

        public static ContainerBuilder RegisterFileReaderServices(this ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleWriter>().As<IWrite>();
            builder.RegisterType<FileReader>().As<IAwersomeTextReader>();

            return builder;
        }
    }
}
