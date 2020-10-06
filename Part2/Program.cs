using System;
using System.Security.Cryptography;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int heads = 0, tails = 0;

            Console.WriteLine("For each coin toss enter either 'h' for heads or 't' for tails.");
            for (int i=1; i<=8; i++)
            {
                Console.Write($"Enter result for toss {i}:");
                if (Console.ReadLine().ToLower().Equals("h"))
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine($"Number of heads: {heads}");
            Console.WriteLine($"Number of tails: {tails}");

            double percentHeads = heads * 100.0 / (heads + tails);
            double percentTails = tails * 100.0 / (heads + tails);

            Console.WriteLine($"Percent heads: {percentHeads}");
            Console.WriteLine($"Percent tails: {percentTails}");
        }
    }
}
