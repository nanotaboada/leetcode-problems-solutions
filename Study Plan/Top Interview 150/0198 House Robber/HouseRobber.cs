/* 
    Problem
    --------------------------------------------------------------------------------
    198. House Robber
*/

/* 
    Solution
    --------------------------------------------------------------------------------
    Taking into account the Topics and Hints provided, a Dynamic Programming
    approach is expected for this solution.

    Dynamic programming (DP) is a powerful technique for solving optimization
    problems by breaking them down into smaller, overlapping sub-problems and
    storing the solutions for future use.
    Here are the key steps involved in the DP approach:

    1. Identify overlapping sub-problems: Analyze the problem and see if it can
    be decomposed into smaller, independent sub-problems. These sub-problems
    should have some overlap, meaning their solutions contribute to the overall
    solution in multiple ways.

    2. Define a recursive solution: Formulate a recursive function that solves
    the entire problem by breaking it down into smaller sub-problems using the
    identified decomposition. This function should call itself with smaller
    inputs until it reaches base cases where the solution is straightforward.

    3. Memoization/Tabulation: Implement a mechanism to store the solutions of
    these sub-problems as they are computed. This avoids redundant computations
    and significantly improves efficiency. Memoization stores solutions based on
    the specific inputs used, while tabulation builds a table of solutions for
    all possible sub-problems based on their size or relevant parameters.

    4. Build the solution: Use the stored solutions (from memoization or
    tabulation) to build the solution for the overall problem.

    Here are some additional points to remember:

    - Identifying overlapping sub-problems is crucial for successful DP 
    application. Not all problems have this characteristic, and applying DP to
    inappropriate problems can lead to worse performance compared to direct
    solutions.

    - Choosing the right data structure for memoization or tabulation depends on
    the nature of the sub-problems and their relationships. Arrays, hash tables,
    and other structures can be used depending on the specific case.
    
    - Visualization tools and diagrams can be helpful in understanding the
    decomposition and solution construction process in DP.

    --------------------------------------------------------------------------------
    1. Identify overlapping sub-problems
    --------------------------------------------------------------------------------

    "Adjacent houses have security systems connected and it will automatically
    contact the police if two adjacent houses were broken into on the same night."

    We have two options:

    - Start with the first house (index 0), skip the second (index 1) and
    continue with the third (index 2).
    
    - Skip the first house (index 0), continue with the second (index 1) and
    skip the third (index 2).

    --------------------------------------------------------------------------------
    2. Define a Recursive Solution
    --------------------------------------------------------------------------------

    To have reached any house (n) along the street, we must either:

    - Have reached house n (and also n-2) but not house n-1, or

     n-2     n-1      n
      ^       ^       ^
    / X \   / $ \   / X \
    | _ |   | _ |   | _ |

    - Have not reached house n, but have reached n-1.

     n-2     n-1      n
      ^       ^       ^
    / $ \   / X \   / $ \
    | _ |   | _ |   | _ |

    Therefore the maximum possible amount of money must be the higher amount
    between our two options, n + n-2 or n-1

    --------------------------------------------------------------------------------
    3. Memoization/Tabulation
    --------------------------------------------------------------------------------

    Let's approach the problem _bottom-up_ (tabulation)

    - This approach builds a table to store the solutions for all sub-problems
    (reaching every step) based on their size (n).

    - The solution for each step is calculated iteratively based on the
    previously computed solutions at smaller steps.

    We will make use of the `money` array to store the maximum amount of each
    option.

    So our base cases will be:

    money[0] = nums[0];
    money[1] = Math.Max(nums[0], nums[1]);

    --------------------------------------------------------------------------------
    4. Build the solution
    --------------------------------------------------------------------------------

    From there, we can apply our solution to calculate the remaining houses,
    starting with the second (`house = 2`) until house n (`street`)

    var one = nums[house] + money[house-2];
    var two = money[house-1];
    money[house] = Math.Max(one, two);

    --------------------------------------------------------------------------------
    - Runtime 69 ms (Beats 82.10% of users with C#)
    - Memory 39.94 MB (Beats 6.11% of users with C#)
*/

class Solution
{
    public int Rob(int[] nums)
    {
        var street = nums.Length;
        if (street == 1) return nums[0];

        var money = new int[street];
        money[0] = nums[0];
        money[1] = Math.Max(nums[0], nums[1]);

        for (var house = 2; house < street; house++)
        {
            var one = nums[house] + money[house-2];
            var two = money[house-1];
            money[house] = Math.Max(one, two);
        }

        return money[street-1];
    }
}