using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Computer_Product
    {
        private string computerName;
        private PcCPU computerCPU;
        private PcMonitor computerMonitor;
        private PcSpeakers computerSpeakers;

        public Computer_Product(string Name)
        {
            computerName = Name;
        }

        public string ComputerName
        {
            get { return computerName; }
        }

        public PcCPU ComputerCPU
        {
            get { return computerCPU; }
            set { computerCPU = value; }
        }
        public PcMonitor ComputerMonitor
        {
            get { return computerMonitor; }
            set { computerMonitor = value; }
        }
        public PcSpeakers ComputerSpeakers
        {
            get { return computerSpeakers; }
            set { computerSpeakers = value; }
        }
        public override string ToString()
        {
            return ($"Assembling: {computerCPU}\nAssembling: {computerMonitor}\nAssembling: {computerSpeakers}");
        }

    }
}
