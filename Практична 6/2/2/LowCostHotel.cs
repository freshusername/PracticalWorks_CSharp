using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class LowCostHotel : AbstractTravel
    {
        public LowCostHotel() : base("LowCost hotel room")
        { }

        public override int GetCost()
        {
            return 100;
        }
    }
    
}
