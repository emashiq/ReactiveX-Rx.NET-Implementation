using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveX.Core;
using ReactiveX.Core.Extension;
using Reactive_Extension_App.ReactiveX.Observables;
using Reactive_Extension_App.ReactiveX.Observers;
namespace Reactive_Extension_App
{
    class Program
    {
        static void Main(string[] args)
        {
           var asyncSubject = new AsyncSubject<string>();
            asyncSubject.OnNext("this");
            asyncSubject.OnNext(" is");
            asyncSubject.OnNext(" my");
            asyncSubject.OnNext(" country");
            PrintItems(asyncSubject);
            asyncSubject.OnCompleted();
            Console.ReadKey();

        }

        static void PrintItems(IObservable<string> items)
        {
            items.Subscribe(Console.Write);
        }
        
    }
}
