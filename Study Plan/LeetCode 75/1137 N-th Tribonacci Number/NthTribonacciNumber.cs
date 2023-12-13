/*
    Problem
    --------------------------------------------------------------------------------
    1137. N-th Tribonacci Number
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 14 ms (Beats 95.91% of users with C#)
    - Memory 26.41 MB (Beats 82.97% of users with C#)
*/
public class Solution
{
    public int Tribonacci(int n)
    {
        // Hint 1
        // Make an array F of length 38, and set F[0] = 0, F[1] = F[2] = 1.
        var F = new int[38];
        F[0] = 0;
        F[1] = F[2] = 1;

        // If n < 3 there is no need to loop -- we already know the values.
        if (n == 0) return 0;
        if (n == 1 || n == 2) return 1;

        // Hint 2
        // Now write a loop where you set F[n+3] = F[n] + F[n+1] + F[n+2]
        for (int i = 3; i <= n; i++)
        {
            F[i] = F[i-1] + F[i-2] + F[i-3];
        }

        // and return F[n].
        return F[n];
    }
}