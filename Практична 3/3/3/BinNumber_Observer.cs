using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class BinNumber_Observer : IObserver
    {
        public string name;
        public int number;
        public BinNumber_Observer(string name, int number)
        {
            this.name = name = this.ToString();
            this.number = number;
        }

        public void NotifyAboutNewNumberAndConvertIt()
        {
            Console.WriteLine($"Hey, *{this.name}*, new number has been added ({this.number}), convert it!");
            string binValue = ConvertNum(this.number);
            Console.WriteLine("Converted: " + binValue);
        }

        public string ConvertNum(int number)
        {
            string binValue = Convert.ToString(number, 2);
            return binValue;
        }
    }
    
}
