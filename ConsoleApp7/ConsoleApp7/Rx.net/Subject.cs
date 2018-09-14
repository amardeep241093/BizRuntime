//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp5
//{
//    class Subject
//    {
//        static void Main(string[] args)
//        {
//            var subject = new Subject<string>();
//            WriteSequenceToConsole(subject);
//            subject.OnNext("a");
//            subject.OnNext("b");
//            subject.OnNext("c");
//            Console.ReadKey();
//        }
//        //Takes an IObservable<string> as its parameter. 
//        //Subject<string> implements this interface.
//        static void WriteSequenceToConsole(IObservable<string> sequence)
//        {
//            //The next two lines are equivalent.
//            //sequence.Subscribe(value=>Console.WriteLine(value));
//            sequence.Subscribe(Console.WriteLine);
//        }
//    }
//}

