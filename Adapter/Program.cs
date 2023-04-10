using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Car car = new Car();

            driver.Travel(car);

            Camel camel = new Camel();
            CamelToTransport camelToTransport = new CamelToTransport(camel);
            driver.Travel(camelToTransport);
            Console.ReadKey();
        }
    }
}
