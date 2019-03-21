using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ButtonFactory : AbstractFactory
    {

        public override AbstractElementHeight createAbstractElementHeight()
        {
            return new ButtonHeight();
        }

        public override AbstractElementWidth createAbstractElementWidth()
        {
            return new ButtonWidth();
        }
    }
}
