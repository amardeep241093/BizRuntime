using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ReplaySubject
    {
        static void Main(string[] args)
        {
            var subject = new ReplaySubject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            Console.ReadKey();
        }

        //Takes an IObservable<string> as its parameter. 
        //ReplaySubject<string> implements this interface.

        private static void WriteSequenceToConsole(ReplaySubject<string> subject)
        {
            //The next two lines are equivalent.
            //sequence.Subscribe(value=>Console.WriteLine(value));
            subject.Subscribe(Console.WriteLine);
        }
    }
       
}
