using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"Program started on main thread{threadId}");

            //1.create the observable
            var obs = Observable.Range(5, 10);

            //2.subscribe to the observer
            var subscription = obs.Subscribe(new Observer());

            Console.ReadKey();
            //3. Dispose the subscription that you dont want to listen anymore.
            subscription.Dispose();

        }

    }
}
