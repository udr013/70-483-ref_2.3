using System;

namespace IDisposables
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DisposableConnection conneçtion = new DisposableConnection())
            {
                Console.WriteLine("Doing something");
            }
            Console.ReadKey();
        }
    }
}
