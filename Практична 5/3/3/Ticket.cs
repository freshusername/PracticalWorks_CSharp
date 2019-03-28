using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Ticket
    {
        protected string Name;
        protected bool isNearWindow;
        protected bool isHot;
        //protected bool CanReturn;
        //protected int Price;
        public AbstractClassPriceStrategy priceStrategy { get; set; }
        public Ticket(string name, bool isnearwindow, bool ishot, AbstractClassPriceStrategy abstractClassPrice)
        {
            this.isHot = ishot;
            this.isNearWindow = isnearwindow;
            this.Name = name;
            priceStrategy = abstractClassPrice;

        }

        public string GetName()
        {
            return $"Ticket's name: {this.Name}";
        }
        public int SetPrice()
        {
            return priceStrategy.AlgoritmPrice(this.isHot, this.isNearWindow);
        }


    }
}
