using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ExtraParcel : AbstractParcel
    {
        public ExtraParcel() : base("Extra parcel")
        { }

        public override int GetCost()
        {
            return 70;
        }
    }
    
}
