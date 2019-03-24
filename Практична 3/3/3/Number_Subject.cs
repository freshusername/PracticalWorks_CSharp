using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Number_Subject : ISubject
    {
        private int number;
        private List<IObserver> _observers = new List<IObserver>();
        public int Number
        {
            get { return number; }
            set
            {
                if (value != 0)
                    Notify();
                number = value;
            }
        }
        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver o in _observers)
            {
                o.NotifyAboutNewNumberAndConvertIt();
            }
        }
    }
}
