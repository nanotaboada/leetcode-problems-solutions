/*  
    Problem
    --------------------------------------------------------------------------------
    1431. Kids With the Greatest Number of Candies
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/solutions/4384104/clean-one-liner-in-c-using-linq-beats-80-21-in-runtime/

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