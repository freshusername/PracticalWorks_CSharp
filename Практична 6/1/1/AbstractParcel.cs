using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public abstract class AbstractParcel
    {
        public AbstractParcel(string name)
        {
            this.Name = name;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();

    }
}
