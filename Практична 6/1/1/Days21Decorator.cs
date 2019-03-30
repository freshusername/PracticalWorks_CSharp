using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Days21Decorator : AbstractTravelDecorator
    {
        public Days21Decorator(string name, AbstractTravel travel) : base(name + " на 21 днів", travel)
        { }
        public override int GetCost()
        {
            return protectedTravel.GetCost() + 21 * 500;
        }
    }
}
