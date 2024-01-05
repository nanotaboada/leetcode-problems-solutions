/*  
    Problem
    --------------------------------------------------------------------------------
    125. Valid Palindrome
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 4 ms (Beats 54.95% of users with Java)
    - Memory 43.11 MB (Beats 56.69% of users with Java)
*/

class Solution {
    public boolean isPalindrome(String s) {
        StringBuilder characters = new StringBuilder();
        for (int index = 0; index < s.length(); index++) {
            char character = s.charAt(index);
            if (Character.isLetterOrDigit(character)) {
                characters.append(Character.toLowerCase(character));
            }
        }
        String forward = characters.toString();
        String backward = new StringBuilder(forward).reverse().toString();
        return forward.equals(backward);
    }
}