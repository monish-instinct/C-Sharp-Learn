using System;

class Program
{
    static int MinRequests(int N)
    {
        return N - 2 + 1;
    }

    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine());
            int minRequests = MinRequests(N);
            Console.WriteLine(minRequests);
        }
    }
}
