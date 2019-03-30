using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class PlainDecorator : AbstractTravelDecorator
    {
        public PlainDecorator(string name, AbstractTravel travel) : base(name + "; подорож на літаку", travel)
        { }
        public override int GetCost()
        {
            return protectedTravel.GetCost() + 2500;
        }
    }
}
