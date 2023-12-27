/*
    Problem
    --------------------------------------------------------------------------------
    1137. N-th Tribonacci Number
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    The Tribonacci series is a generalization of the Fibonacci sequence where
    each term is the sum of the three preceding terms.

    https://leetcode.com/problems/n-th-tribonacci-number/solutions/4431186/java-time-complexity-o-n-space-complexity-o-1-beats-100-in-runtime/

    - Time Complexity O(n)
    - Space Complexity O(1)

    - Runtime 104 ms (Beats 100.00% of users with Java)
    - Memory 40.42 MB (Beats 6.29% of users with Java)
*/

class Solution {
    public int tribonacci(int n) {
        // Hint 1
        // Make an array F of length 38, and set F[0] = 0, F[1] = F[2] = 1.
        int[] F = new int[38];
        F[0] = 0;
        F[1] = F[2] = 1;
        // If n < 3 there is no need to loop -- we already know the values.
        if (n == 0) return 0;
        if (n == 1 || n == 2) return 1;
        // Hint 2
        // Now write a loop where you set F[n+3] = F[n] + F[n+1] + F[n+2]
        for (int i = 3; i <= n; i++) {
            // F[n-3]   F[n-2]   F[n-1]   F[n]   F[n+1]   F[n+2]   F[n+3]
            //                            <------------------------------
            //                            F[n] + F[n+1] + F[n+2] = F[n+3]
            // F[n-3] + F[n-2] + F[n-1] = F[n]
            // <------------------------------
            F[i] = F[i-1] + F[i-2] + F[i-3];
        }
        // and return F[n].
        return F[n];
    }
}
