
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    abstract class AbstractParcelDecorator : AbstractParcel
    {
        protected AbstractParcel ProtectedParcel;
        public AbstractParcelDecorator(string str, AbstractParcel parcel) : base(str)
        {
            this.ProtectedParcel = parcel;

        }
    }
}
