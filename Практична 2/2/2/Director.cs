using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Director
    {
        public void Construct(AbstractBuilder abstractBuilder)
        {
            abstractBuilder.BuildCPU();
            abstractBuilder.BuildMonitor();
            abstractBuilder.BuildSpeakers();
        }
    }
}
