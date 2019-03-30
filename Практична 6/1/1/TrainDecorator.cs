using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class TrainDecorator : AbstractTravelDecorator
    {
        public TrainDecorator(string name, AbstractTravel travel) : base(name + "; подорож на поїзді", travel)
        { }
        public override int GetCost()
        {
            return protectedTravel.GetCost() + 450;
        }
    }
}
