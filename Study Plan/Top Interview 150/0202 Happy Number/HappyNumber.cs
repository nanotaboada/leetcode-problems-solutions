/*  
    Problem
    --------------------------------------------------------------------------------
    202. Happy Number
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/happy-number/solutions/4423432/c-beats-87-in-runtime-hashset-to-avoid-endless-loop-time-and-space-complexity-o-log-n/

    - Runtime 26 ms (Beats 87.46% of users with C#)
    - Memory 29.50 MB (Beats 28.23% of users with C#)
*/

public class Solution
{
    public bool IsHappy(int n)
    {
        // To avoid entering in an endless loop, that is, obtaining a result N
        // that leads to the same result N, and as suggested by the Topics of 
        // the problem, we will make use of a HashSet to store the results that
        // we've already processed or computed through the process.
        var computed = new HashSet<int>();

        while(!computed.Contains(n))
        {
            computed.Add(n);

            if(n == 1)
            {
                return true;
            }

            n = SumOfSquaresOfDigits(n);
        }

        return false;
    }

    private int SumOfSquaresOfDigits(int number)
    {
        var sum = 0;
        var digit = 0;

        // The following is a popular way to split a number into its digits:
        while (number > 0)
        {
            digit = number % 10;
            number /= 10;
            sum += digit * digit;
        }

        return sum;
    }
}