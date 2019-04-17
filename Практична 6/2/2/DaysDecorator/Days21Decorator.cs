using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Days21Decorator : AbstractTravelDecorator
    {
        public Days21Decorator(AbstractTravel travel) : base(travel.Name + " на 21 днів", travel)
        { }
        public override int GetCost()
        {
            int price = protectedTravel.GetCost() + 21 * protectedTravel.GetCost();
            return price;
        }
    }
}
