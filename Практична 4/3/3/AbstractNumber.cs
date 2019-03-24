using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    abstract class AbstractNumber
    {
        public int num { get; set; }
        public abstract int ConvertNumber(int num);
        public AbstractNumber(int num)
        {
            this.num = num;
        }
        public abstract void Display();

    }
}
