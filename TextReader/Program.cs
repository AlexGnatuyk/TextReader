using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TextReader.DependencyInjection;
using TextReader.Interfaces;

namespace TextReader
{
    class Program
    {
       private static IContainer Container { get; set; }
       
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterServices();
            Container = builder.Build();

            ReadAndWrite();

        }

        public static void ReadAndWrite()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var reader = scope.Resolve<IAwersomeTextReader>();
                var writer = scope.Resolve<IWrite>();
                
                writer.Write(reader.Read());
            }
        }
    }
}
