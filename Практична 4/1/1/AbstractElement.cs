using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    abstract class AbstractElement
    {
        public abstract void Accept(AbstractVisitor visitor);
        public string SomeState { get; set; }
    }
}
