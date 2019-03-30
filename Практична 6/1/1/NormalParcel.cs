using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class NormalParcel : AbstractParcel
    {
        public NormalParcel() : base("Normal parcel")
        {}

        public override int GetCost()
        {
            return 40;
        }
    }
}
