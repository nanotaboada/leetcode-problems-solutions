/*  
    Problem
    --------------------------------------------------------------------------------
    20. Valid Parentheses
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/valid-parentheses/solutions/4422923/c-based-on-hints-beats-92-in-runtime-time-and-space-complexity-o-n/

    - Runtime 49 ms (Beats 92.18% of users with C#)
    - Memory 39.50 MB (Beats 25.21% of users with C#)
    
*/

public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length == 1) return false;

        // Hint 1
        // Use a stack of characters.
        var characters = new Stack<char>(s.Length);

        for (var character = 0; character < s.Length; character++)
        {
            // Hint 2
            // When you encounter an opening bracket,
            if (s[character] == '('
                || s[character] == '['
                || s[character] == '{')
            {
                // push it to the top of the stack.
                characters.Push(s[character]);
            } 
            // Hint 3
            // When you encounter a closing bracket, check if the top of the stack
            // was the opening for it.
            else if ((s[character] == ')' && characters.Any() && characters.Peek() == '(')
                || (s[character] == ']' && characters.Any() && characters.Peek() == '[')
                || (s[character] == '}' && characters.Any() && characters.Peek() == '{'))
            {
                // If yes, pop it from the stack.
                characters.Pop();
            }
            else
            {
                // Otherwise, return false.
                return false;
            }
        }

        return !characters.Any();
    }
}