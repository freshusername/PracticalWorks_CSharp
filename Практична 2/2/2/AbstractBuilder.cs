using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    enum PcMonitor
    {
        Monitor_Samsung,
        Monitor_LG
    };

    enum PcCPU
    {
        CPU_Intel,
        CPU_AMD
    };

    enum PcSpeakers
    {
        Speakers_None,
        Speakers_Stereo,
        Speakers_Surround
    };

    abstract class AbstractBuilder
    {
        public abstract void BuildCPU();
        public abstract void BuildMonitor();
        public abstract void BuildSpeakers();
        public abstract Computer_Product computerProduct { get; }
    }
}
