using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class HexNumber_Observer : IObserver
    {
        public string name;
        public int number;
        public HexNumber_Observer(string name, int number)
        {
            this.name = name = this.ToString();
            this.number = number;
        }

        public void NotifyAboutNewNumberAndConvertIt()
        {
            Console.WriteLine($"Hey, *{this.name}*, new number has been added ({this.number}), convert it!");
            string HexValue = ConvertNum(this.number);
            Console.WriteLine("Converted: 0x" + HexValue);
        }

        public string ConvertNum(int number)
        {
            string hexValue = number.ToString("X");
            return hexValue;
        }
    }
}
