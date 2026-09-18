using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Mart_LongestIncreasingSubsequence.Services
{
    public class SequenceSolver
    {
        public static List<int> FindLongestIncreasingSubsequence(string input)
        {
            var numbers = input.Split(' ')
                               .Where(s => int.TryParse(s, out _))
                               .Select(int.Parse)
                               .ToList();

            int n = numbers.Count;
            int[] dp = new int[n];
            int[] prev = new int[n];
            Array.Fill(dp, 1);
            Array.Fill(prev, -1);

            int maxLen = 1, lastIndex = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }
                if (dp[i] > maxLen)
                {
                    maxLen = dp[i];
                    lastIndex = i;
                }
            }

            var result = new List<int>();
            while (lastIndex != -1)
            {
                result.Add(numbers[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            result.Reverse();
            return result;
        }
    }
}
