using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp5
{
    class Observer : IObserver<int>
    {
        public void OnNext(int value)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"value recieved on thread{threadId}:{value}");
            //3. method that will recieve the value from the observable
            // Console.WriteLine(value);
        }

        public void OnError(Exception error)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"value recieved on thread{threadId}:{error.Message}");
            // Console.WriteLine($"Error: {error.Message}");
        }
        public void OnCompleted()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"value recieved on thread{threadId}");
            // Console.WriteLine("Observable complete");
        }


    }
}
