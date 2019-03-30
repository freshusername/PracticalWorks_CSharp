
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    abstract class AbstractTravelDecorator : AbstractTravel
    {
        protected AbstractTravel protectedTravel;
        public AbstractTravelDecorator(string str, AbstractTravel travel) : base(str)
        {
            this.protectedTravel = travel;

        }
    }
}
