using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Rx.net
{
    class Implicit
    {
        static void Main(string[] args)
        {
                var subject = new Subject<string>();
                subject.Subscribe(Console.WriteLine);
                subject.OnNext("a");
                subject.OnNext("b");
                subject.OnCompleted();
                subject.OnNext("c");//once the sequence is completed,no other activities will happen
            }
        }
    }

