using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Customer2 : CustomerElement
    {
        public string Name { get; set; }
        public string PlaceToGo { get; set; }
        public bool Taked { get; set; }

        public Customer2(string name, string placetogo)
        {
            this.Name = name;
            this.PlaceToGo = placetogo;
            this.Taked = false;
        }
        public override void Accept(AbstractTaxi_Visitor visitor)
        {
            visitor.VisitCustomer(this);
        }
    }
}
