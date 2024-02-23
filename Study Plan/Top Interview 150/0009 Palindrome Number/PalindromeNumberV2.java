/*  
    Problem
    --------------------------------------------------------------------------------
    9. Palindrome Number
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 4 ms (Beats 100.00% of users with Java)
    - Memory 43.82 MB (Beats 69.62% of users with Java)
*/

public class Solution {
    public boolean isPalindrome(int x) {
        if (x < 0) return false;
        int original = x;
        int reversed = 0;
        while (x > 0) {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        return original == reversed;
    }
}
