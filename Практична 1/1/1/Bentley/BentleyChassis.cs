using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class BentleyChassis : AbstractChassis
    {
        public override void Interact(AbstractEngine engine)
        {
            Console.WriteLine(this + " interacts with " + engine);
        }
    }
}
