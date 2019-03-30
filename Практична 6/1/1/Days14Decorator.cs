using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Days14Decorator : AbstractTravelDecorator
    {
        public Days14Decorator(string name, AbstractTravel travel) : base(name + " на 14 днів", travel)
        { }
        public override int GetCost()
        {
            return protectedTravel.GetCost() + 14 * 500;
        }
    }
}
