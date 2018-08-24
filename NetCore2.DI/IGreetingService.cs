using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore2.DI
{
    public interface IGreetingService
    {
        string Greeting(string message);
    }
}
