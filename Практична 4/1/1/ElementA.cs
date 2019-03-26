using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ElementA : AbstractElement
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitElementA(this);
        }
        public void OperationA() { }
    }
}
