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
                var url = new DataSourceOptions
                {
                    urlSource = new Uri("https://timetable.spbu.ru/api/v1/addresses?seating=0&capacity=15")
                };
                builder.RegisterInstance(url);
                Container = builder.Build();

                Write();
            }
            else
            {
                builder.RegisterFileReaderServices();
                
                var url = new DataSourceOptions
                {
                    urlSource = new Uri("file://C:/Users/st044618/Source/Repos/TextReader/TextReader/Data.txt")
                };
                builder.RegisterInstance(url);
                Container = builder.Build();

                Write();
            }
            
            
        }

        public static void Write()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
               var writer = scope.Resolve<IWrite>();
               
                writer.Write();
            }
        }
    }
}
