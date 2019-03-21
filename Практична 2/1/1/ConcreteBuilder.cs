using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ConcreteBuilder : Builder
    {
        Product product = new Product();

        public override void CreatePart1()
        {
            product.Add("Part 1") ;
        }

        public override void CreatePart2()
        {
            product.Add("Part 2");
        }

        public override void CreatePart3()
        {
            product.Add("Part 3");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
