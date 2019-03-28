using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class BusinessClassPrice : AbstractClassPriceStrategy
    {
        public override int AlgoritmPrice(bool isNearWindow, bool isHot)
        {
            if (isNearWindow == true && isHot == true)
            {
                return 350*2*2;
            }
            if (isNearWindow == true)
            {
                return 350 * 2;
            }
            else return 350;
        }
    }
}
