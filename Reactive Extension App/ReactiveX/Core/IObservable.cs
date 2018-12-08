using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveX.Core
{
    public interface IIObservable<out T>
    {
        /// <summary>
        /// Notify the o
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        IDisposable Subscribe(IIObserver<T> observer);
    }
}
