/*
    Problem
    --------------------------------------------------------------------------------
    746. Min Cost Climbing Stairs
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 1 ms (Beats 46.04% of users with Java)
    - Memory 43.18 MB (Beats 48.49% of users with Java)
*/

class Solution {
    public int minCostClimbingStairs(int[] cost) {
        int steps = cost.length;
        int[] price = new int[steps];
        price[0] = cost[0];
        price[1] = cost[1];
        for (int step = 2; step < steps; step++) {
            int penultimate = cost[step] + price[step-1];
            int antepenultimate = cost[step] + price[step-2];
            price[step] = Math.min(penultimate, antepenultimate);
        }
        return Math.min(price[steps-1], price[steps-2]);
    }
}
