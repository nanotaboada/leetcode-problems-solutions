/*  
    Problem
    --------------------------------------------------------------------------------
    125. Valid Palindrome
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 3 ms (Beats 76.39% of users with Java)
    - Memory 42.85 MB (Beats 73.80% of users with Java)
*/

public class Solution {
    public boolean isPalindrome(String s) {
        if (s.length() == 1) return true;
        String phrase = s.toLowerCase();
        int left = 0;
        int right = phrase.length() - 1;
        while (left < right) {
            char first = phrase.charAt(left);
            char last = phrase.charAt(right);
            if (!Character.isLetterOrDigit(first)) {
                left++;
            } else if (!Character.isLetterOrDigit(last)) {
                right--;
            } else {
                if (first != last) {
                    return false;
                }
                left++;
                right--;   
            }
        }
        return true;
    }
}