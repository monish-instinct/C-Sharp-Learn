using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine());
            int[] blocks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(blocks);

            bool possible = false;
            if (N <= 2)
            {
                possible = true;
            }
            else
            {
                int firstTripMax = blocks[N - 2];
                int secondTripMax = blocks[N - 1];

                if (firstTripMax < secondTripMax)
                    possible = true;
            }

            if (possible)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
