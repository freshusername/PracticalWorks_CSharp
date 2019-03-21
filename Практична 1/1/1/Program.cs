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
            Client client = null;

            client = new Client(new BentleyCarManufacturer());
            client.Run();

            client = new Client(new MaseratiCarManufacturer());
            client.Run();

            Console.ReadKey();
        }
    }
}
