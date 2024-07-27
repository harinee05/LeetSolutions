using System;
using System.Collections.Generic;

public class Solution
{
    public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost)
    {
        // Initialize graph with all possible characters
        Dictionary<char, Dictionary<char, int>> graph = new Dictionary<char, Dictionary<char, int>>();
        for (char c = 'a'; c <= 'z'; c++)
        {
            graph[c] = new Dictionary<char, int>();
            graph[c][c] = 0;  // Direct transformation to itself costs 0
        }

        // Build the graph
        for (int i = 0; i < original.Length; i++)
        {
            char from = original[i], to = changed[i];
            int newCost = cost[i];
            if (!graph[from].ContainsKey(to) || graph[from][to] > newCost)
            {
                graph[from][to] = newCost;
            }
        }

        // Floyd-Warshall algorithm to find all-pairs shortest paths
        for (char k = 'a'; k <= 'z'; k++)
            for (char i = 'a'; i <= 'z'; i++)
                for (char j = 'a'; j <= 'z'; j++)
                    if (graph[i].ContainsKey(k) && graph[k].ContainsKey(j))
                    {
                        int newCost = graph[i][k] + graph[k][j];
                        if (!graph[i].ContainsKey(j) || graph[i][j] > newCost)
                            graph[i][j] = newCost;
                    }

        // Calculate total cost
        long totalCost = 0;
        for (int i = 0; i < source.Length; i++)
        {
            char from = source[i], to = target[i];
            if (!graph[from].ContainsKey(to))
                return -1;  // Impossible to transform
            totalCost += graph[from][to];
        }

        return totalCost;
    }
}
