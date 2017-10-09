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
        public static ContainerBuilder RegisterServices(this ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleWriter>().As<IWrite>();
            builder.RegisterType<UrlReader>().As<IAwersomeTextReader>();
            

            return builder;
        }
    }
}
