using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Context
    {
        AbstractClassStrategy abstractClass;
        public Context(AbstractClassStrategy abstractPrinter)
        {
            this.abstractClass = abstractPrinter;
        }
        public string ExcecuteAlgoritm()
        {
            return this.abstractClass.Algoritm();
        }
    }
}
