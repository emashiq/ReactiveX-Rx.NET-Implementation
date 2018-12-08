using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveX.Core
{
    public interface IIObserver<in T>
    {
        /// <summary>
        /// This Method call the next observer
        /// </summary>
        /// <param name="value"></param>
        void OnNext(T value);
        /// <summary>
        /// This Method perform for error 
        /// </summary>
        /// <param name="ex"></param>
        void OnError(Exception ex);
        /// <summary>
        /// This method perform termination
        /// </summary>
        void OnCompleted();
    }
}
