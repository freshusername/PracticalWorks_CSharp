using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Observer Pattern - 3";
            Number_Subject numSubject = new Number_Subject();

            Console.WriteLine("Input value of property of Number_Subject class: ");
            numSubject.Number = int.Parse(Console.ReadLine());

            IObserver observer1 = new HexNumber_Observer("HexConverter", numSubject.Number);
            numSubject.Add(observer1);

            IObserver observer2 = new BinNumber_Observer("BinConverter", numSubject.Number);
            numSubject.Add(observer2);

            //observer1.NotifyAboutNewNumberAndConvertIt();
            numSubject.Number += 0;

            Console.ReadKey();

        }
    }
}
