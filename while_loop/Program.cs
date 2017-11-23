using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 5;

            while (counter > 0)
            {
                Console.WriteLine("Counter = {0}", counter);
                counter = counter - 1;
            }
        }
    }
}
