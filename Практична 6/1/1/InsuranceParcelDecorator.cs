using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class InsuranceParcelDecorator : AbstractParcelDecorator
    {
        public InsuranceParcelDecorator(AbstractParcel parcel) : base(parcel.Name + " зі страховкою", parcel)
        { }

        public override int GetCost()
        {
            return ProtectedParcel.GetCost() - 25;
        }
    }
}
