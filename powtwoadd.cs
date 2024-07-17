using System;

class Program
{
    static int MinPowersOf2(int N, int K)
    {
        int powersNeeded = 0;
        while (N < K)
        {
            N += (int)Math.Pow(2, powersNeeded);
            powersNeeded++;
        }
        return powersNeeded;
    }

    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int minPowers = MinPowersOf2(N, K);
            Console.WriteLine(minPowers);
        }
    }
}
