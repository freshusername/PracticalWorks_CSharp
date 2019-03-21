using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Client
    {
        private AbstractChassis chassis;
        private AbstractEngine engine;
        private AbstractSalon salon;

        public Client(AbstractCarManufaturer abstractCarManufaturer)
        {
            //абстрагирование процессов инстанцирования
            chassis = abstractCarManufaturer.CreateChassis();
            engine = abstractCarManufaturer.CreateEngine();
            salon = abstractCarManufaturer.CreateSalon();
             
        }

        public void Run()
        {
            chassis.Interact(engine);
            salon.Interact(chassis);
        }
    }
}
