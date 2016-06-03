using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using depa;
using System.IO;

namespace app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                              .AddJsonFile("appsettings.json")
                              .SetBasePath(Path.GetDirectoryName(typeof(Program).GetTypeInfo().Assembly.Location));

            var config = builder.Build();

            var depAConfig = new DepAConfiguration();
            ConfigurationBinder.Bind(config, depAConfig);

     
             var depaClass = new DepAClass(depAConfig);
            depaClass.DepAMethod();
            Console.ReadKey();
        }
    }
}
