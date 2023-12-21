/*  
    Problem
    --------------------------------------------------------------------------------
    191. Number of 1 Bits
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 39.76 MB (Beats 37.79% of users with Java)
*/

class Solution {
    // you need to treat n as an unsigned value
    public int hammingWeight(int n) {
        return Integer.bitCount(n);
    }
}
