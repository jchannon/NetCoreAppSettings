using depb;
using System;

namespace depa
{
    public class DepAClass
    {
        private readonly DepAConfiguration _configuration;

        public DepAClass(DepAConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void DepAMethod()
        {
            Console.WriteLine("DepAMethod");
            Console.WriteLine(_configuration.Logging.LogLevel.Microsoft);
            var depbClass = new DepBClass();
            depbClass.DoSomething();
        }
    }
}