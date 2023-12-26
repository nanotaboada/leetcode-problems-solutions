/*
    Problem
    --------------------------------------------------------------------------------
    746. Min Cost Climbing Stairs
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 70 ms (Beats 96.11% of users with C#)
    - Memory 41.73 MB (Beats 6.73%of users with C#)
*/

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var steps = cost.Length;
        var price = new int[steps];
        price[0] = cost[0];
        price[1] = cost[1];

        for (var step = 2; step < steps; step++)
        {
            var penultimate = cost[step] + price[step-1];
            var antepenultimate = cost[step] + price[step-2];
            price[step] = Math.Min(penultimate, antepenultimate);
        }

        return Math.Min(price[steps-1], price[steps-2]);
    }
}