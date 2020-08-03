using System;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Boxing();
        }


        static void Boxing()
        {
            object number = 5;
            int sum = 0;
            for(int i = 0; i < 10; i++)
            {
                sum += (int)number;
            }
            Console.WriteLine(sum);
        }
    }
}
