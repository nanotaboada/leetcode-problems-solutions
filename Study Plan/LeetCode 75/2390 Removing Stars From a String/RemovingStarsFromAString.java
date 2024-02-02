/*
    Problem
    --------------------------------------------------------------------------------
    2390. Removing Stars From a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 40 ms (Beats 71.64% of users with Java)
    - Memory 47.28 MB (Beats 25.43% of users with Java)
*/

class Solution {
    public String removeStars(String s) {
        // Hint 2
        // Use a stack to store the characters.
        // https://www.baeldung.com/java-deque-vs-stack
        Deque<Character> characters = new ArrayDeque<>(s.length());
        for (Character character : s.toCharArray()) {
            if (!characters.isEmpty() && character == '*') {
                // Pop one character off the stack at each star.
                characters.pop();
            } else {
                // Otherwise, we push the character onto the stack.
                characters.push(character);
            }
        }
        StringBuilder original = new StringBuilder(characters.size());
        while (!characters.isEmpty()) {
            original.append(characters.pop());
        }
        // Due to the last-in, first-out (LIFO) nature of the Deque,
        // we have to reverse it in order to restore the original sequence. 
        return original.reverse().toString();
    }
}