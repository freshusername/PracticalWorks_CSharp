using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    abstract class AbstractElement
    {
        public abstract string Accept(AbstractVisitor visitor);
    }
}
