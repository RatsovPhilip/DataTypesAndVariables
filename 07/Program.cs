using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp = a;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
            a = b;
            b = temp;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
        }
    }
}
