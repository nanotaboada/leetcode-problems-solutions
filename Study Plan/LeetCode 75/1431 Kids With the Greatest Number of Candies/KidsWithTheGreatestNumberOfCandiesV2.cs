/*  
    Problem
    --------------------------------------------------------------------------------
    1431. Kids With the Greatest Number of Candies
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/solutions/4384104/c-based-on-hints-beats-82-in-runtime-time-and-space-complexity-o-n/

    - Runtime 107 ms (Beats 82.50% of users with C#)
    - Memory 48.71 MB (Beats 9.32% of users with C#)
*/

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var result = new List<bool>(candies.Length);

        // Hint 1
        // Use greedy approach. For each kid check if 
        // candies[i] + extraCandies ≥ maximum in Candies[i].
        var maxCandies = candies.Max();

        foreach (var candy in candies)
        {
            result.Add(candy + extraCandies >= maxCandies);
        }

        return result;
    }
}