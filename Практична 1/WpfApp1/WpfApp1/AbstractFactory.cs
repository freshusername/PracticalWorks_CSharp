using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    abstract class AbstractFactory
    {
        public abstract AbstractElementHeight createAbstractElementHeight();
        public abstract AbstractElementWidth createAbstractElementWidth();        
    }
}
