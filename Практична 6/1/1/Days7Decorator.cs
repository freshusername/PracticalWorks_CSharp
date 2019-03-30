using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Days7Decorator : AbstractTravelDecorator
    {
        public Days7Decorator(string name, AbstractTravel travel) : base(name + " на 7 днів", travel)
        { }
        public override int GetCost()
        {
            return protectedTravel.GetCost() + 7 * 500;
        }
    }
}
