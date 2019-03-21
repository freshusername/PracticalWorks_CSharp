using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    abstract class AbstractUIFactory
    {
        public abstract AbstractHelp CreateHelp();
        public abstract AbstractImages CreateImages();
        public abstract AbstractLocale CreateLocale();
    }
}
