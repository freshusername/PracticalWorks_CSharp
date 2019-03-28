using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class PershuiClassPrice : AbstractClassPriceStrategy
    {
        public override int AlgoritmPrice(bool isNearWindow, bool isHot)
        {
            if (isNearWindow == true && isHot == true)
            {
                return 550 * 2 * 2;
            }
            if (isNearWindow == true)
            {
                return 550 * 2;
            }
            else return 550;
        }
    }
}
