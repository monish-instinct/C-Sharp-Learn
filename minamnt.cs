using System;
using System.Collections.Generic;

class Program
{
    static double Distance(int[] island1, int[] island2)
    {
        int x1 = island1[0];
        int y1 = island1[1];
        int x2 = island2[0];
        int y2 = island2[1];
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double CalculateMinimumAmount(List<int[]> islands, int K, int C)
    {
        int n = islands.Count;
        double totalCost = K * n;
        double minCost = totalCost;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                double distance = Distance(islands[i], islands[j]);
                double bridgesCost = distance * K / C;
                minCost = Math.Min(minCost, totalCost + bridgesCost);
            }
        }

        return Math.Floor(minCost);
    }

    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine());
            List<int[]> islands = new List<int[]>();
            for (int i = 0; i < N; i++)
            {
                int[] island = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                islands.Add(island);
            }
            int K = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            double minAmount = CalculateMinimumAmount(islands, K, C);
            Console.WriteLine(minAmount);
        }
    }
}
