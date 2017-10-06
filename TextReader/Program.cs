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
       public static IContainer Container { get; set; }
        public static String content = "dom";
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterServices();
            Container = builder.Build();
            ConsoleWriter.Write(content);

        }
    }
}
