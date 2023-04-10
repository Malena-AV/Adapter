using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Camel : IAnimal
    {
        public void Run()
        {
            Console.WriteLine("Еду на верблюдике");
        }
    }
}
