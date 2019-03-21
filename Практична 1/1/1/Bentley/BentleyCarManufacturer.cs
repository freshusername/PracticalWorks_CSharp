using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class BentleyCarManufacturer : AbstractCarManufaturer
    {
        public override AbstractChassis CreateChassis()
        {
            return new BentleyChassis();
        }

        public override AbstractEngine CreateEngine()
        {
            return new BentleyEngine();
        }

        public override AbstractSalon CreateSalon()
        {
            return new BentleySalon();
        }
    }
}
