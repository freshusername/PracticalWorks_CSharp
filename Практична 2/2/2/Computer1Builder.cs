using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Computer1Builder : AbstractBuilder
    {
        Computer_Product computer1;
        public override Computer_Product computerProduct
        {
            get { return computer1; }
        }


        public Computer1Builder()
        {
            computer1 = new Computer_Product("First Computer");
        }

        public override void BuildCPU()
        {
            computer1.ComputerCPU = PcCPU.CPU_Intel;
        }

        public override void BuildMonitor()
        {
            computer1.ComputerMonitor = PcMonitor.Monitor_Samsung;
        }

        public override void BuildSpeakers()
        {
            computer1.ComputerSpeakers = PcSpeakers.Speakers_None;
        }

        
    }
}
