using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class EliteCostHotel : AbstractTravel
    {
        public EliteCostHotel() : base("EliteCost hotel room")
        { }

        public override int GetCost()
        {
            return 700;
        }
    }
}
