using System;
using System.Collections.Generic;

namespace kattis
{
    internal class ADifferentProblem
    {
        static void Main()
        {
            string line;
            var list = new List<long>();
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                var nums = line.Split(' ');
                var a = Int64.Parse(nums[0]);
                var b = Int64.Parse(nums[1]);

                list.Add(Math.Abs(a - b));
            }

            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
