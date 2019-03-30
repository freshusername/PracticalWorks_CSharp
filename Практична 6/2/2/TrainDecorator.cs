using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class TrainDecorator : AbstractTravelDecorator
    {
        public TrainDecorator(AbstractTravel travel) : base(travel.Name + "; подорож на поїзді", travel)
        { }
        public override int GetCost()
        {
            return protectedTravel.GetCost() + 450;
        }
    }
}
