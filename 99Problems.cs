using System;

namespace kattis
{
    internal class _99Problems
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            if (input <= 99)
                Console.WriteLine(99);
            else
            {
                var remain = input % 100;
                if (remain == 0)
                    Console.WriteLine(input - 1);
                else
                {
                    if (remain >= 49)
                        Console.WriteLine(input + (99 - remain));
                    else
                        Console.WriteLine(input - (remain + 1));
                }
            }
        }
    }
}
