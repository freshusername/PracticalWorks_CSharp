using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ObjectStructure
    {
        List<AbstractElement> elements = new List<AbstractElement>();
        public void Add(AbstractElement el)
        {
            elements.Add(el);
        }
        public void Remove(AbstractElement el)
        {
            elements.Remove(el);
        }
        public void Accept(AbstractVisitor visitor)
        {
            foreach (AbstractElement e in elements)
            {
                e.Accept(visitor);
            }
        }


    }
}
