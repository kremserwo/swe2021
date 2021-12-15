using System;

namespace StateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            State CurrentState = new StartState();
            CurrentState.DoAction(context);

            Console.WriteLine("Current State: {0}", CurrentState);

            CurrentState = new StopState();
            CurrentState.DoAction(context);

            Console.WriteLine("Current State: {0}", CurrentState);
        }
    }
}
