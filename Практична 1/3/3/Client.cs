using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _3
{
    class Client
    {
        private AbstractHelp help;
        private AbstractImages images;
        private AbstractLocale locale;
        
        public Client(AbstractUIFactory factory)
        {
            this.help = factory.CreateHelp();
            this.images = factory.CreateImages();
            this.locale = factory.CreateLocale();
        }
        public string ViewImgs(int n)
        {
            return images.imgStr(n);
        }
        public string ViewLocal()
        {
            return locale.locStr();

        }
        public string ViewHelp()
        {
            return help.helpStr();
        }


    }
}
