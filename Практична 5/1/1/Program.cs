using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mass[i] = rnd.Next(1, 9);
            }
            BulbSort b = new BulbSort();
            MergeSort c = new MergeSort();
            ShellSort d = new ShellSort();
            Console.WriteLine("BulbSort Class: ");
            b.Alghorithm(mass);
            Console.WriteLine();
            c.Alghorithm(mass);
            Console.WriteLine("MergeSort Class: ");
            c.PrintArray(mass);
            d.Alghorithm(mass);
            Console.WriteLine("ShellSort Class: ");
            d.show(mass);

            Console.ReadKey();

        }
    }
}
