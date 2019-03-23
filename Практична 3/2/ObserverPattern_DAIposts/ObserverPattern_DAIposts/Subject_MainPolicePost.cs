using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_DAIposts
{
    class Subject_MainPolicePost : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();
        private int offender_speed;
        public int Offender_speed
        {
            get { return offender_speed; }
            set { if (offender_speed > 50) Notify();
                  offender_speed = value; }
        }
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);

        }

        public void Notify()
        {
            foreach (IObserver obs in _observers) { obs.NotifyAboutOffender(); }
        }

        
    }
}
