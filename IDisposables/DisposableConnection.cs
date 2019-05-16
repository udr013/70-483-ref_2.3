using System;
using System.Collections.Generic;
using System.Text;

namespace IDisposables
{
    class DisposableConnection : IDisposable
    {
        //clean up after it's used, it can not be used anymore though might still be in memory
        public void Dispose()
        {
            Console.WriteLine("Disposable Called");
        }
    }

}
