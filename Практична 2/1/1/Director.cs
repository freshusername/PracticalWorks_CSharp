using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Director
    {
        public Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.CreatePart1();
            builder.CreatePart2();
            builder.CreatePart3();
        }
    }
}
