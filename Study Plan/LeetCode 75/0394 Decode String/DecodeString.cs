/*  
    Problem
    --------------------------------------------------------------------------------
    394. Decode String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 47 ms (Beats 91.46% of users with C#)
    - Memory 38.53 MB (Beats 64.90% of users with C#)
*/


public class Solution
{
    public string DecodeString(string s)
    {
        var encoded = s;
        var decoded = string.Empty;
        var letters = new Stack<string>(s.Length);
        var numbers = new Stack<int>(s.Length);
        var k = 0;

        foreach (char character in encoded)
        {
            if (char.IsDigit(character))
            {
                k = k * 10 + (character - '0'); 
            }
            else if (character == '[')
            {
                letters.Push(decoded);
                numbers.Push(k);
                decoded = string.Empty;
                k = 0;
            }
            else if(character == ']')
            {                  
                decoded = letters.Pop() + string.Join("", Enumerable.Repeat(decoded, numbers.Pop()));
            } 
            else
            {
                decoded += character;
            }
                
        }

        return decoded;
    }
}
