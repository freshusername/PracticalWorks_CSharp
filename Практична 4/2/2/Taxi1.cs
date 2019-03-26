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
            customer1.Taked = true;
            return s = $"Customer's mobile : {customer1.Name},\nDestination: {customer1.PlaceToGo}\nIn Process: {customer1.Taked}";
        }

    }
}
