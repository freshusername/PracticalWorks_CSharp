using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Taxi1 : AbstractTaxi_Visitor
    {
        public override string VisitCustomer(CustomerElement customer)
        {
            string s;
            Customer1 customer1 = customer as Customer1;
            customer1.Name = "John";
            customer1.PlaceToGo = "Університетська, 4";
            return s = $"customer's name : {customer1.Name},\n Destination: {customer1.PlaceToGo}";
        }

    }
}
