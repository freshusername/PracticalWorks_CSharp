using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _555
{
    abstract class AbstractConditioner
    {
        Temperature product;
        public abstract Temperature FactoryMethod();
        public string AnOperation(string t)
        {
            product = FactoryMethod();
            return t;
        }
    }
}
