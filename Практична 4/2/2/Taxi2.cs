using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Taxi2 : AbstractTaxi_Visitor
    {
        public override string VisitCustomer(CustomerElement customer)
        {
            string s;
            Customer2 customer2 = customer as Customer2;
            customer2.Name = "Valentine";
            customer2.PlaceToGo = "Сіді Таль, 5";
            return s = $"Customer's name : {customer2.Name},\n Destination: {customer2.PlaceToGo}";
        }
    }
}
