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

            var appConfig = new AppConfiguration();
            ConfigurationBinder.Bind(config, appConfig);

            var depaClass = new DepAClass();
            depaClass.DepAMethod();
            Console.ReadKey();
        }
    }
}
