using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _555
{
    class WarmTemperature : Temperature
    {
        public WarmTemperature(string t)
        {
            Gradus(t);//Console.WriteLine(this.GetHashCode());
        }

        public override string Gradus(string t)
        {
            return t;
        }
    }
}
