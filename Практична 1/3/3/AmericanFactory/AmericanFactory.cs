using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class AmericanFactory : AbstractUIFactory
    {
        public override AbstractHelp CreateHelp()
        {
            return new AmericanHelp();
        }

        public override AbstractImages CreateImages()
        {
            return new AmericanImages();
        }

        public override AbstractLocale CreateLocale()
        {
            return new AmericanLocale();
        }
    }
}
