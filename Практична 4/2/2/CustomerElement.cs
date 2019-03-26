using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    abstract class CustomerElement
    {
        public CustomerElement()
        {

        }
        public abstract void Accept(AbstractTaxi_Visitor visitor);
    }
}
