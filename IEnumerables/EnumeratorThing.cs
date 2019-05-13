using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace IEnumerables
{
    class EnumeratorThing : IEnumerator<int>, IEnumerable
    {
        int count;
        int limit;

        public EnumeratorThing(int limit)
        {
            count = 0;
            this.limit = limit;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public int Current => count;

        object IEnumerator.Current => count;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if(++count == limit)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            count = 0;
        }
    }
}
