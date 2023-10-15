using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    private static int MinCost(int[] costs)
    {
        int n = costs.Length;
        int[] sum = new int[n];

        sum[0] = costs[0];
        sum[1] = costs[1];

        for (int i = 2; i < n; i++)
        {
            sum[i] = Math.Min(sum[i - 1], sum[i - 2]) + costs[i];
        }

        return Math.Min(sum[n - 1], sum[n - 2]);
    }

    public static void Main(string[] args)
    {
        int[] costs = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int minCost = MinCost(costs);

        Console.WriteLine(minCost);
    }
}