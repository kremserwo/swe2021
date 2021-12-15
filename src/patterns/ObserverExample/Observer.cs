using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ObserverExample
{
    public interface Observer
    {
        public void Notify(string newState);
    }

    public class PrintObserver : Observer
    {
        public void Notify(string newState)
        {
            Console.WriteLine("New state: {0}", newState);
        }
    }

    public abstract class Observable
    {
        private List<Observer> observers = new List<Observer>();
        private string CurrentState;


        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAll(string message)
        {
            foreach(var observer in observers)
            {
                observer.Notify(message);
            }
        }

        public void ChangeState(string newState)
        {
            this.CurrentState = newState;
            NotifyAll(newState);
        }
    }

    public class RandomObservable : Observable
    {
        public void StartEmitting()
        {
            while (true)
            {
                ChangeState(new Random().NextDouble().ToString());
                Thread.Sleep(1000);
            }
        }
    }
}
