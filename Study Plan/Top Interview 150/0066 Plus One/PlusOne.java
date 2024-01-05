/*  
    Problem
    --------------------------------------------------------------------------------
    66. Plus One
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/plus-one/solutions/4453463/java-time-and-space-complexity-o-n-runtime-0-ms-beats-100-analysis-in-comments/

    - Time and Space Complexity O(n)

    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 42.30 MB (Beats 5.77% of users with Java)
*/

class Solution {
    public int[] plusOne(int[] digits) {
        // Loop backwards (right-to-left)
        // e.g. [ 4, 3, 2, 1 ]
        for (int rightToLeft = digits.length - 1; rightToLeft >= 0; rightToLeft--) {
            // If the last digit is less than 9, just increment by one and return
            if (digits[rightToLeft] < 9) { // digits[3] = 1
                digits[rightToLeft]++; // [ 4, 3, 2, 2 ]
                return digits;
            // If the last digit is greater than 9, then set the current digit to 0
            // and the next iteration will handle the carry anyways
            // e.g. [1, 9, 9]
            } else {
                digits[rightToLeft] = 0;
                // 1st iteration [1, 9, 0]
                // 2nd iteration [1, 0, 0]
            }
        }
        // If the last digit is greater than 9 through the whole cycle, then the
        // number would be all nines, e.g. [9, 9, 9], and we will need to add an
        // extra digit to the collection to address that case
        // Create a collection with an additional digit and set the first to 1
        var digitsPlusOne = new int[digits.length + 1]; // [ 0, 0, 0, 0 ]
        digitsPlusOne[0] = 1; // [ 1, 0, 0, 0 ]
        return digitsPlusOne;
    }
}