using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace IEnumerables
{
    class EnumeratorThing2 : IEnumerable<int>
    {
       
        private int limit;

        public EnumeratorThing2(int limit)
        {
            this.limit = limit;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 1; i < limit; i++)
            {
                yield return i;
            }
        }

        //this will return the next yield duringloop until last is reached.
        //public IEnumerator<int> GetEnumerator()
        //{
            
        //        yield return 200;
        //        yield return 300;
        //        yield return 400;
            
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
