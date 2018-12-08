using System;
using System.Collections.Generic;
using System.Text;
using ReactiveX.Core;

namespace Reactive_Extension_App.ReactiveX.Observers
{
    public class PrintCurrentDateInMiliSecondObserver : IIObserver<DateTime>
    {
        public void OnCompleted()
        {
            Console.WriteLine("The Observer has completed on :"+ DateTime.Now.Millisecond );
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("That has some error "+ error);
        }

        public void OnNext(DateTime value)
        {
            Console.WriteLine("On Next Called On : "+value.Millisecond);
        }
    }
}
