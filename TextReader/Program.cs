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
            Console.Write("1 - Read http status \n2 - Read from File\n\n");
            string choose = Console.ReadLine();
            var builder = new ContainerBuilder();

            if (choose.Equals("1"))
            {

                builder.RegisterUrlReaderServices();
                Container = builder.Build();

                ReadAndWrite();
            }
            else
            {
                builder.RegisterFileReaderServices();
                Container = builder.Build();

                ReadAndWrite();
            }
            
            
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
