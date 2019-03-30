using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public abstract class AbstractTravel
    {
        public AbstractTravel(string name)
        {
            this.Name = name;
        }
        public string Name { get; protected set; }

        public abstract int GetCost();

    }
}
