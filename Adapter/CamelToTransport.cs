using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CamelToTransport: ITransport
    {
        //паттерн позволяет использовать разные классы вместе, когда их интерфейсы не совместимы
        private Camel camel;
        public CamelToTransport(Camel camel)
        {
            this.camel = camel;
        }

        public void Drive()
        {
            camel.Run();
        }
    }
}
