using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    abstract class AbstractTaxi_Visitor
    {
        public abstract void VisitCustomer(CustomerElement customer);
    }
}
