using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class CarDecorator : AbstractTravelDecorator
    {
        public CarDecorator(string name, AbstractTravel travel) : base(name + "; подорож на машині", travel)
        { }
        public override int GetCost()
        {
            return protectedTravel.GetCost() + 1500;
        }
    }
}
