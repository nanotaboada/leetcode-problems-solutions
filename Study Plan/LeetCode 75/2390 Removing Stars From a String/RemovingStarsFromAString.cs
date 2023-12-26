/*
    Problem
    --------------------------------------------------------------------------------
    2390. Removing Stars From a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 84 ms (Beats 92.86% of users with C#)
    - Memory 46.41 MB (Beats 26.25% of users with C#)
*/

public class Solution
{
    public string RemoveStars(string s)
    {
        // Hint 2
        // Use a stack to store the characters.
        var characters = new Stack<char>();

        foreach (var character in s)
        {
            if (character == '*')
            {
                // Pop one character off the stack at each star.
                characters.Pop();
            }
            else
            {
                // Otherwise, we push the character onto the stack.
                characters.Push(character);
            }
        }
        // Due to the last-in, first-out (LIFO) nature of the Stack,
        // we have to reverse it in order to restore the original sequence. 
        return new string(characters.Reverse().ToArray());
    }
}