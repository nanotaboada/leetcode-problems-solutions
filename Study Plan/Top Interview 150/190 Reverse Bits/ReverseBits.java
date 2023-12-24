/*  
    Problem
    --------------------------------------------------------------------------------
    190. Reverse Bits
*/

/*  
    Solution
    --------------------------------------------------------------------------------

    - Runtime 5 ms (Beats 5.28% of users with Java)
    - Memory 42.17 MB (Beats 5.68% of users with Java)
*/

class Solution {
    // you need treat n as an unsigned value
    public int reverseBits(int n) {
        // Returns a string representation of the integer argument as an
        // unsigned integer in base 2.
        String binaryString = Integer.toBinaryString(n);
        binaryString = String.format("%32s", binaryString).replace(' ', '0');
        StringBuilder reversed = new StringBuilder(binaryString).reverse();
        long unsigned = Long.parseLong(reversed.toString(), 2);
        return (int)unsigned;
    }
}