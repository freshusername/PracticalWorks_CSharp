using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Context
    {
        AbstractPrinterStrategy abstractPrinter { get; set; }
        public Context(AbstractPrinterStrategy abstractPrinter)
        {
            abstractPrinter = this.abstractPrinter;
        }
        public string ExcecuteAlgoritm()
        {
            return this.abstractPrinter.Algoritm();
        }
    }
}
