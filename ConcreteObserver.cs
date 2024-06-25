using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class ConcreteObserver : IObserver
    {
        private string _name;
        private string _message;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            _message = message;
            Console.WriteLine($"Observer {_name} received message: {_message}");
        }
    }
}
