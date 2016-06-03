using System;

namespace depb
{
    public class DepBClass
    {
        private readonly DepBConfiguration _configuration;

        public DepBClass(DepBConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void DoSomething()
        {
            Console.WriteLine(_configuration.Smtp.Server);
        }
    }
}