using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    abstract class Builder
    {
        public Builder() {}
        public abstract void CreatePart1();
        public abstract void CreatePart2();
        public abstract void CreatePart3();

        public abstract Product GetResult();
    }
}
