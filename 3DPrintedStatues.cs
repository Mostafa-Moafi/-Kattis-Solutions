using System;

namespace kattis
{
    internal class _3DPrintedStatues
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            int day = 0;
            int statue = int.Parse(s);
            int printer = 1;
            int statueProduced = 0;

            int doublePrinter = printer << 1;

            while (statueProduced < statue)
            {
                day++;
                if (printer == statue)
                    statueProduced += printer;
                else
                {
                    if (doublePrinter < statue)
                    {
                        printer = doublePrinter;
                        doublePrinter = printer << 1;
                    }
                    else
                        statueProduced += printer;
                }
            }

            Console.WriteLine(day);
        }
    }
}
