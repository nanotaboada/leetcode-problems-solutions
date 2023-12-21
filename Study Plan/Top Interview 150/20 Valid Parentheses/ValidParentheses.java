/*  
    Problem
    --------------------------------------------------------------------------------
    20. Valid Parentheses
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/valid-parentheses/solutions/4433109/straightforward-solution-in-java-based-on-provided-hints-beats-82-in-runtime/

    - Runtime 2 ms (Beats 82.70% of users with Java)
    - Memory 41.74 MB (Beats 6.54% of users with Java)
*/

class Solution {
    public boolean isValid(String s) {
        if (s.length() == 1) return false;
        // Hint 1
        // Use a stack of characters.
        Stack<Character> characters = new Stack<>();
        for (int character = 0; character < s.length(); character++) {
            // Hint 2
            // When you encounter an opening bracket,
            if (s.charAt(character) == '('
                || s.charAt(character) == '['
                || s.charAt(character) == '{') {
                // push it to the top of the stack.
                characters.push(s.charAt(character));
            // Hint 3
            // When you encounter a closing bracket, check if the top of the stack
            // was the opening for it.
            }  else if ((s.charAt(character) == ')' 
                && !characters.empty() 
                && characters.peek() == '(')
                || 
                (s.charAt(character) == ']' 
                && !characters.empty() 
                && characters.peek() == '[')
                || 
                (s.charAt(character) == '}' 
                && !characters.empty() 
                && characters.peek() == '{')) {
                // If yes, pop it from the stack.
                characters.pop();
            } else {
                // Otherwise, return false.
                return false;
            }
        }
        return characters.empty();
    }
}
