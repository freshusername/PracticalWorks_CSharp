using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _555
{
    class SamsungConditioner : AbstractConditioner
    {
        public override Temperature FactoryMethod()
        {
            return new ColdTemperature("cold");
        }
    }
}
