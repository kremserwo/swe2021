using System;
using System.Threading;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Observer observer = new PrintObserver();
            RandomObservable observable = new RandomObservable();

            observable.Subscribe(observer);

            Thread t = new Thread(() => observable.StartEmitting());
            t.Start();
        }
    }
}
