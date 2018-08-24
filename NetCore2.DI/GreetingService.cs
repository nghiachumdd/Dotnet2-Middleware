using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore2.DI
{
    public class GreetingService : IGreetingService
    {
        public string Greeting(string message)
        {
            return $"{message}";
        }
    }
}
