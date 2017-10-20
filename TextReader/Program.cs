using System;
using Autofac;
using TextReader.DependencyInjection;



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
           
        }

        public static void Write(Uri uri)
        {
            using (var scope = Container.BeginLifetimeScope())
            {
               var writerService = scope.Resolve<IWriterFactory>();
               var writer = writerService.Create(uri); 
               writer.Write();
                
            }
        }

        public static void Run()
        {
            while (true)
            {
                Console.Write("1 - Read http status \n2 -  Read from File\n3 - Exit\n");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    var urlSource = new Uri("https://timetable.spbu.ru/api/v1/addresses?seating=0&capacity=15");
                    Write(urlSource);
                }
                if (choose == "2")
                {
                    var urlSource = new Uri("file://C:/Users/st044618/Source/Repos/TextReader/TextReader/Data.txt");
                    Write(urlSource);
                }
                if (choose == "3")
                {
                    Environment.Exit(0);
                }
            }
        }
        
    }
}
