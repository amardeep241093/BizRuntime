using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;

namespace ConsoleApp7.Rx.net
{
    public class FactoryMethod
    {
        static void Main(string[] args)
        {

    IObservable<T> Return<T>(T value)
            {
                return Observable.Create<T>(o =>
                {
                    o.OnNext(value);
                    o.OnCompleted();
                    return Disposable.Empty;
                });
            }
       IObservable<T> Never<T>()
            {
                return Observable.Create<T>(o =>
                {
                    return Disposable.Empty;
                });
            }
      IObservable<T> Throws<T>(Exception exception)
            {
                return Observable.Create<T>(o =>
                {
                    o.OnError(exception);
                    return Disposable.Empty;
                });
            }
        }
    }
}
