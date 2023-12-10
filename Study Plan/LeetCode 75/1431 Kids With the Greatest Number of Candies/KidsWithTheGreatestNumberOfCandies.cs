/*  
    Problem
    --------------------------------------------------------------------------------
    1431. Kids With the Greatest Number of Candies
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 131 ms (Beats 80.21% of users with C#)
    - Memory 45.24 MB (Beats 7.08% of users with C#)
*/

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        return candies
            .Select(kid => kid + extraCandies >= candies.Max())
            .ToList();
    }
}