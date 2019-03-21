using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Computer3Builder : AbstractBuilder
    {
        Computer_Product computer3;
        public override Computer_Product computerProduct
        {
            get { return computer3; }
        }

        public Computer3Builder()
        {
            computer3 = new Computer_Product("Third Computer");
        }

        public override void BuildCPU()
        {
            computer3.ComputerCPU = PcCPU.CPU_AMD;
        }

        public override void BuildMonitor()
        {
            computer3.ComputerMonitor = PcMonitor.Monitor_Samsung;
        }

        public override void BuildSpeakers()
        {
            computer3.ComputerSpeakers = PcSpeakers.Speakers_Surround;
        }
    }
}
