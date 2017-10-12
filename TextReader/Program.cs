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
            while (true)
            {
                Console.Write("1 - Read http status \n2 - Read from File\n3 - Exit\n");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    WriteFile("1");
                    string test = "test";
                }
                if (choose == "2")
                {
                    WriteFile("2");
                }
                if (choose == "3")
                {
                    Environment.Exit(0);
                }
            }           
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

        public static void WriteFile(string id)
        {
            using (var scope = Container.BeginLifetimeScope())
            {
               var writer = scope.Resolve<WriterService>();
                if (id == "2")
                {
                    writer.WriteFile();
                }
                if (id == "1")
                {
                    writer.WriteHttp();
                }
                
            }
        }
        
    }
}
