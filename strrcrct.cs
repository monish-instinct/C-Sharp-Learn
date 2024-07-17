using System;
using System.Collections.Generic;

class PermutationChecker
{
    static bool CanCreatePermutation(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        Dictionary<char, int> s1Freq = new Dictionary<char, int>();
        foreach (char c in s1)
        {
            if (!s1Freq.ContainsKey(c))
                s1Freq[c] = 1;
            else
                s1Freq[c]++;
        }

        foreach (char c in s2)
        {
            if (!s1Freq.ContainsKey(c))
                return false;
            else
            {
                s1Freq[c]--;
                if (s1Freq[c] == 0)
                    s1Freq.Remove(c);
            }
        }

        return s1Freq.Count == 0;
    }

    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            if (CanCreatePermutation(s1, s2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
