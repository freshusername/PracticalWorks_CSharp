using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class ObjectStructure
    {
        List<AbstractElement> users = new List<AbstractElement>();
        public void Add(AbstractElement element)
        {
            users.Add(element);
        }

        public void Remove(AbstractElement customer)
        {
            users.Remove(customer);
        }

        public void Accept(AbstractVisitor visitor)
        {
            foreach (AbstractElement user in users)
            {
                user.Accept(visitor);
            }

        }

    }
}
