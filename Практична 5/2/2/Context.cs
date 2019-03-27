using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Context
    {
        AbstractPrinterStrategy abstractPrinter;
        public Context(AbstractPrinterStrategy abstractPrinter)
        {
            this.abstractPrinter = abstractPrinter;
        }
        public string ExcecuteAlgoritm()
        {
            return this.abstractPrinter.Algoritm();
        }
    }
}
