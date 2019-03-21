using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class UkrainianFactory : AbstractUIFactory
    {
        public override AbstractHelp CreateHelp()
        {
            return new UkrainianHelp();
        }

        public override AbstractImages CreateImages()
        {
            return new UkrainianImages();
        }

        public override AbstractLocale CreateLocale()
        {
            return new UkrainianLocale();
        }


    }
}
