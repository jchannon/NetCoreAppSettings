using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using depa;
using System.IO;
using depb;
using TinyIoC;

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

            var depBConfig = new DepBConfiguration();
            ConfigurationBinder.Bind(config,depBConfig);

            var container = TinyIoCContainer.Current;
            container.Register(depAConfig);
            container.Register(depBConfig);

            container.Register<IDepAClass, DepAClass>();
            container.Register<IDepBClass, DepBClass>();

            var depaClass = container.Resolve<IDepAClass>();
            depaClass.DepAMethod();
            Console.ReadKey();
        }
    }
}
