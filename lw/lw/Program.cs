using System;

namespace lw
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            while (a < 100000000)
            {
                a *= a;
                Console.WriteLine(a);
            }
        }
    }
}
