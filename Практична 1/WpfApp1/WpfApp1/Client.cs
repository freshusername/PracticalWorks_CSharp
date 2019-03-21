using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Client
    {
        private AbstractElementHeight abstractElementHeight;
        private AbstractElementWidth abstractElementWidth;

        public Client(AbstractFactory abstractFactory)
        {
            abstractElementHeight = abstractFactory.createAbstractElementHeight();
            abstractElementWidth = abstractFactory.createAbstractElementWidth();
        }

        public void Run(string width, string height)
        {
            abstractElementWidth.setWidth(width);
            abstractElementHeight.setHeight(height);
        }

    }
}
