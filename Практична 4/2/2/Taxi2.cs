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
            customer2.Taked = true;
            return s = $"Customer's mobile : {customer2.Name},\nDestination: {customer2.PlaceToGo}\nIn Process: {customer2.Taked}";
        }
    }
}
