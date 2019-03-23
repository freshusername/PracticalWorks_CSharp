using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_DAIposts
{
    class Observer_DAI_post : IObserver
    {
        public string Name { get; private set; }
        public Observer_DAI_post(string name)
        {
            this.Name = name;
        }

        public string NotifyAboutOffender()
        {
            string str = $"Hey *{this.Name}*, порушник на білому VW Golf перевищив швидкість, номери: АА3456ВО. Оголошено план перехоплення!";
            return str;
        }
    }
}
