using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    abstract class Pizza : ItemInterface
    {
        public abstract float Price();
        public abstract string Name();
        public abstract string Size();
    }
}
