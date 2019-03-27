using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class User1 : AbstractElement
    {
        public override string Accept(AbstractVisitor visitor)
        {
            visitor.VisitUser1(this);
            return " ";
        }
    }
}
