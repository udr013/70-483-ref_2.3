using System;
using System.Collections.Generic;
using System.Text;

namespace IDisposables
{
    class DisposableConnection : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposable Called");
        }
    }

}
