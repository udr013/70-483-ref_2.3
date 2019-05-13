using System;

namespace IEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get an emunerator to iterate through
            var helloworld = "Hello World";
            var stringEnumerator = helloworld.GetEnumerator();

            while (stringEnumerator.MoveNext())
            {
                Console.WriteLine(stringEnumerator.Current);
            }

            foreach(char c in helloworld)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            EnumeratorThing things = new EnumeratorThing(15);
             while (things.MoveNext())
            {
                Console.WriteLine(things.Current);
            }

            EnumeratorThing2 things2 = new EnumeratorThing2(15);
            //this doesn't work....
            //while (things2.MoveNext())
            //{
            //    Console.WriteLine(things2.Current);
            //}

           foreach(int thing in things2)
            {
                Console.WriteLine(thing);
            }
            Console.ReadKey();
        }
    }
}
