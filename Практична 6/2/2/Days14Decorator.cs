using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Days14Decorator : AbstractTravelDecorator
    {
        public Days14Decorator(AbstractTravel travel) : base(travel.Name + " на 14 днів", travel)
        { }
        public override int GetCost()
        {
            int price = protectedTravel.GetCost() + 14 * protectedTravel.GetCost();
            return price;
        }
    }
}
