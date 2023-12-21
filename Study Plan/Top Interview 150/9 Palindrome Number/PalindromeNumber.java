/*  
    Problem
    --------------------------------------------------------------------------------
    9. Palindrome Number
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 7 ms (Beats 20.57% of users with Java)
    - Memory 44.34 MB (Beats 6.92% of users with Java)
*/

class Solution {
    public boolean isPalindrome(int x) {
        String original = String.valueOf(x);
        String reversed = new StringBuilder(original).reverse().toString();
        return original.equals(reversed);
    }
}
