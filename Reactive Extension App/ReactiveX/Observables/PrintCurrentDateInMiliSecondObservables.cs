using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Text;
using ReactiveX.Core;

namespace Reactive_Extension_App.ReactiveX.Observables
{
    public class PrintCurrentDateInMiliSecondObservables:IIObservable<DateTime>
    {
        public IDisposable Subscribe(IIObserver<DateTime> observer)
        {
            observer.OnNext(DateTime.Now);
            observer.OnNext(DateTime.Now);
            observer.OnNext(DateTime.Now);
            observer.OnCompleted();
            return Disposable.Empty;
        }
    }
}
