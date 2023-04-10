using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Car : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Еду на машине");
        }
    }
}
