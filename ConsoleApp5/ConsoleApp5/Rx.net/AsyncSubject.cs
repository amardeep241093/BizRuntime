using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class AsyncSubject
    {
        static void Main(string[] args)
        {
            var subject = new AsyncSubject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
          //  subject.OnNext("d"); //not print after completed
            Console.ReadKey();
        }

        private static void WriteSequenceToConsole(AsyncSubject<string> subject)
        {
            subject.Subscribe(Console.WriteLine);

        }
    }
}
