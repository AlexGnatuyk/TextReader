using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TextReader.DependencyInjection;
using TextReader.Interfaces;
using TextReader.Services;

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

            Run();
            //if (choose.Equals("1"))
            //{

            //    builder.RegisterUrlReaderServices();
            //    Container = builder.Build();

            //    Write();
            //}
            //else
            //{
            //    builder.RegisterFileReaderServices();
            //    Container = builder.Build();

            //    Write();
            //}


        }

        public static void WriteFile(Uri uri)
        {
            using (var scope = Container.BeginLifetimeScope())
            {
               var writer = scope.Resolve<WriterService>();
               writer.Create(uri);
               writer.Write();
                
            }
        }

        public static void Run()
        {
            while (true)
            {
                Console.Write("1 - Read http status \n2 - Read from File\n3 - Exit\n");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    var urlSource = new Uri("https://timetable.spbu.ru/api/v1/addresses?seating=0&capacity=15");
                    WriteFile(urlSource);
                }
                if (choose == "2")
                {
                    var urlSource = new Uri("file://C:/Users/st044618/Source/Repos/TextReader/TextReader/Data.txt");
                    WriteFile(urlSource);
                }
                if (choose == "3")
                {
                    Environment.Exit(0);
                }
            }
        }
        
    }
}
