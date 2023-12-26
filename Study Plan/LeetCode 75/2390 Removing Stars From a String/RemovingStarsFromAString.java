/*
    Problem
    --------------------------------------------------------------------------------
    2390. Removing Stars From a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 80 ms (Beats 43.55% of users with Java)
    - Memory 46.38 MB (Beats 28.80% of users with Java)
*/

class Solution {
    public String removeStars(String s) {
        // Hint 2
        // Use a stack to store the characters.
        Stack<Character> characters = new Stack<>();
        for (Character character : s.toCharArray()) {
            if (character == '*') {
                // Pop one character off the stack at each star.
                characters.pop();
            } else {
                // Otherwise, we push the character onto the stack.
                characters.push(character);
            }
        }
        // Due to the last-in, first-out (LIFO) nature of the Stack,
        // we have to reverse it in order to restore the original sequence. 
        StringBuilder original = new StringBuilder(characters.size());
        while (!characters.isEmpty()) {
            original.append(characters.pop());
        }
        return original.reverse().toString();
    }
}