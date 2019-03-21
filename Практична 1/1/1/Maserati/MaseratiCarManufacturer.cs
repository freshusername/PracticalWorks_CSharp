using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class MaseratiCarManufacturer : AbstractCarManufaturer
    {
        public override AbstractChassis CreateChassis()
        {
            return new MaseratiChassis();
        }

        public override AbstractEngine CreateEngine()
        {
            return new MaseratiEngine();
        }

        public override AbstractSalon CreateSalon()
        {
            return new MaseratiSalon();
        }
    }
}
