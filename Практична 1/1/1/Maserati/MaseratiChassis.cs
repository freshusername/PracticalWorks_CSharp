using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class MaseratiChassis : AbstractChassis
    {
        public override void Interact(AbstractEngine engine)
        {
            Console.WriteLine(this + " interacts " + engine);
        }
    }
}
