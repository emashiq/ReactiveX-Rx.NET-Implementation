using System;
using System.Reactive.Linq;
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
            PrintCurrentDateInMiliSecondObservables printCurrentDateInMiliSecondObservables = new PrintCurrentDateInMiliSecondObservables();
            PrintCurrentDateInMiliSecondObserver printCurrentDateInMiliSecondObserver = new PrintCurrentDateInMiliSecondObserver();
            printCurrentDateInMiliSecondObservables.PrintUnixTimestamp();
            Console.WriteLine("-------------------------");
            printCurrentDateInMiliSecondObservables.Subscribe(printCurrentDateInMiliSecondObserver);
            Console.ReadKey();
        }
    }
}
