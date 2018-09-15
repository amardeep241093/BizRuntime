using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class BehaviorSubject
    {
        static void Main(string[] args)
        {
            //Need to provide a default value.
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            //subject.Subscribe(Console.WriteLine);
            subject.OnNext("c");
            subject.OnNext("d");
            subject.OnCompleted();
            subject.Subscribe(Console.WriteLine);
            Console.ReadLine();

        }
    }
}

