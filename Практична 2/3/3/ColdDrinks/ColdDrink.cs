using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    abstract class ColdDrink : ItemInterface
    {
        public abstract float price();

        public string Name()
        {
            throw new NotImplementedException();
        }

        public float Price()
        {
            throw new NotImplementedException();
        }

        public string Size()
        {
            throw new NotImplementedException();
        }


    }
}
