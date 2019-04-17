using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class NormalCostHotel : AbstractTravel
    {
        public NormalCostHotel() : base("NormalCost hotel room")
        {}

        public override int GetCost()
        {
            return 300;
        }
    }
}
