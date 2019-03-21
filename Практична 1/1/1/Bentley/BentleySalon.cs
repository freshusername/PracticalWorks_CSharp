using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class BentleySalon : AbstractSalon
    {
        public override void Interact(AbstractChassis chassis)
        {
            Console.WriteLine(this + " interacts with " + chassis);
        }
    }
}
