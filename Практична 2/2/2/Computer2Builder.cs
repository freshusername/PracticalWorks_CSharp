using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Computer2Builder : AbstractBuilder
    {
        Computer_Product computer2;

        public override Computer_Product computerProduct
        {
            get { return computer2; }
        }

        public Computer2Builder()
        {
            computer2 = new Computer_Product("Second Computer");
        }

        public override void BuildCPU()
        {
            computer2.ComputerCPU = PcCPU.CPU_AMD;
        }

        public override void BuildMonitor()
        {
            computer2.ComputerMonitor = PcMonitor.Monitor_LG;
        }

        public override void BuildSpeakers()
        {
            computer2.ComputerSpeakers = PcSpeakers.Speakers_Stereo;
        }
    }
}
