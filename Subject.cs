using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string _message;

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(_message);
            }
        }
    }
}
