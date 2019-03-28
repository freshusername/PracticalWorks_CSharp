using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public abstract class AbstractClassPriceStrategy
    {
        public abstract int AlgoritmPrice(bool IsNearWindow, bool isHot);
    }
}
