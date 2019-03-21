using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _3
{
    class OrderedItems : ItemInterface
    {
        private ArrayList items = new ArrayList();
        //private List<ItemInterface> items = new List<ItemInterface>();

        public void addItems(ItemInterface iteminterface)
        {
            items.Add(iteminterface);
        }

        float sum = 0;
        public float getCost()
        {
            foreach (ItemInterface i in items)
            {
                sum += i.Price();
            }
            return sum;
        }

        public void showItems()
        {
            foreach (ItemInterface i in items)
            {
                Console.WriteLine(i.Name() + " ");
            }
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public string Size()
        {
            throw new NotImplementedException();
        }

        public float Price()
        {
            throw new NotImplementedException();
        }
    }
}
