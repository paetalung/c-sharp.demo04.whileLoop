using System;

namespace demo04.whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int max_count = 10;

            while(count <= max_count)
            {
                count++;
                Console.WriteLine("Round " + count + ".");
            }
        }
    }
}
