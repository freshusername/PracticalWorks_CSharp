using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ElementB : AbstractElement
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitElementB(this);
        }
        public void OperationB() { }
    }
}
