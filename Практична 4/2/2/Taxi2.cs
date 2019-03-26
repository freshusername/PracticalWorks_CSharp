using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Taxi2 : AbstractTaxi_Visitor
    {
        public override void VisitCustomer(CustomerElement customer)
        {
            Customer2 customer2 = customer as Customer2;
            customer2.Name = "Valentine";
            customer2.PlaceToGo = "Сіді Таль, 5";
            Console.WriteLine($"Customer's name : {customer2.Name},\n Destination: {customer2.PlaceToGo}");
        }
    }
}
