/*
    Problem
    --------------------------------------------------------------------------------
    746. Min Cost Climbing Stairs
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    Taking into account the Topics and Hints provided, a Dynamic Programming
    approach is expected for this solution.

    --------------------------------------------------------------------------------
    Dynamic Programming (DP):

    An algorithmic paradigm for solving optimization problems.
    It works by breaking down a problem into smaller, overlapping subproblems,
    solving each subproblem only once, and storing the results for future reuse.
    This avoids redundant calculations and improves efficiency.

    Key Steps:

    - Identify Overlapping Subproblems: Recognize that the problem can be
      divided into smaller, overlapping subproblems.

    - Define a Recursive Solution: Express the solution to the problem in terms
      of the solutions to its subproblems.

    - Memoize or Tabulate Solutions: Store the solutions to subproblems to avoid
      recalculation.

    - Construct the Optimal Solution: Build the overall solution from the saved
      subproblem solutions.
    --------------------------------------------------------------------------------
    Identify Overlapping Subproblems
    --------------------------------------------------------------------------------
    "To reach the top of the floor", we have two options:

    - "Start from the step with index 0", pay that cost, climb one step,
        pay that cost as well.
    - "Start from the step with index 1", pay that cost, climb two steps,
        pay that cost as well.
    --------------------------------------------------------------------------------
    Define a Recursive Solution
    --------------------------------------------------------------------------------
    To have reached any step (n) we must either:
    
    - Have climbed 1 step from the penultimate step (n-1), or

    1 step
               +  n
          n-1 ____|
        ____ |

    - Have climbed 2 steps from the antepenultimate step (n-2)

    2 steps
               +  n
              ____|
    n-2 ____ |

    We need to sum because we have to pay a cost for every step we take.

    Therefore the minimum cost to reach step n will be the cheapest between our
    possible options, taking one step or two steps.
    --------------------------------------------------------------------------------
    Memoize or Tabulate Solutions
    --------------------------------------------------------------------------------
    We will make use of the price array to store the minimum cost of each option.
    
    As the description suggests, let's approach the problem bottom-up (tabulation),
    So our base cases will be:
    "start from the step with index 0, or the step with index 1."

    price[0] = cost[0]
    price[1] = cost[1]

    From there, we can apply our recursive solution to calculate the remaining
    steps, starting with the third (step = 2) until step n (stair)

    price[2] = Math.Min(cost[step] + price[step-1], cost[step] + price[step-2])

    Finally, the latest 2 elements of our record will have minimum costs of the
    previous steps, but we need to return also the cheapest between them.
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/min-cost-climbing-stairs/solutions/4475426/c-dynamic-programming-step-by-step-analysis-time-and-space-complexity-0-n/

    - Runtime 70 ms (Beats 96.11% of users with C#)
    - Memory 41.73 MB (Beats 6.73%of users with C#)
*/

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        if (cost.Length < 2) return cost[0];
        if (cost.Length == 2) return cost[1];

        var stair = cost.Length;
        
        var price = new int[stair];
        price[0] = cost[0];
        price[1] = cost[1];

        for (var step = 2; step < stair; step++)
        {
            var one = cost[step] + price[step-1];
            var two = cost[step] + price[step-2];
            price[step] = Math.Min(one, two);
        }

        return Math.Min(price[price.Length-1], price[price.Length-2]);
    }
}