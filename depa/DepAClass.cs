using depb;
using System;

namespace depa
{
    public class DepAClass
    {
        public void DepAMethod()
        {
            Console.WriteLine("DepAMethod");
            var depbClass = new DepBClass();
            depbClass.DoSomething();
        }
    }
}