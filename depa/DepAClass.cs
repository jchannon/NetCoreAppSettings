using depb;
using System;

namespace depa
{
    public class DepAClass : IDepAClass
    {
        private readonly DepAConfiguration _configuration;
        private readonly IDepBClass _depBClass;

        public DepAClass(DepAConfiguration configuration, IDepBClass depBClass)
        {
            _configuration = configuration;
            _depBClass = depBClass;
        }

        public void DepAMethod()
        {
            Console.WriteLine("DepAMethod");
            Console.WriteLine(_configuration.Logging.LogLevel.Microsoft);
            
            _depBClass.DoSomething();
        }
    }
}