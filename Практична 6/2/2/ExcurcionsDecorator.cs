using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class ExcurcionsDecorator : AbstractTravelDecorator
    {
        public ExcurcionsDecorator(AbstractTravel travel) : base(travel.Name + " з додатковими екскурсіями", travel)
        { }

        public override int GetCost()
        {
            return protectedTravel.GetCost() + 777;
        }
    }
}
