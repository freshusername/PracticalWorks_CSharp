using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Dispetcher_ObjectStructure
    {
        List<CustomerElement> customers = new List<CustomerElement>();
        public void AddCustomer(CustomerElement customer)
        {
            customers.Add(customer);
        }

        public void Remove(CustomerElement customer)
        {
            customers.Remove(customer);
        }

        public void Accept(AbstractTaxi_Visitor visitor)
        {
            foreach (CustomerElement cust in customers)
            {
                cust.Accept(visitor);
            }

        }
    }
}
