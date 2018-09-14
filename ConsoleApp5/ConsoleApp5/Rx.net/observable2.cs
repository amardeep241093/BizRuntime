using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class observable2
    {
        static void Main(string[] args)
        {
        /*    //create an observable from one of the operator
            //on the System.Reactive.Linq.Observable class
            var obs = Observable.Range(5, 10);
            IObservable<int> observer = Observer.Create<int>(
                 //recieve the value from the observable via onNext handler
                 Console.WriteLine,
                 (error) => { Console.WriteLine($"Error:{error.Message}"); },
                 () => { Console.WriteLine("observation complete"); }
                 );
            //subscribe to the observable,passing to the observer
            var subscription = obs.Subscribe(observer);
            Console.ReadLine();
            subscription.Dispose();
            */
        }
    }
}
