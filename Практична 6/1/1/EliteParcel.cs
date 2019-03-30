using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class EliteParcel : AbstractParcel
    {
        public EliteParcel() : base("Elite parcel")
        { }

        public override int GetCost()
        {
            return 140;
        }
    }
}
