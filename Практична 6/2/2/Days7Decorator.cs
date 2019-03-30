using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Days7Decorator : AbstractTravelDecorator
    {
        public Days7Decorator(AbstractTravel travel) : base(travel.Name + " на 7 днів", travel)
        { }
        public override int GetCost()
        {
            int price = protectedTravel.GetCost() + 7 * protectedTravel.GetCost();
            return price;
        }
    }
}
