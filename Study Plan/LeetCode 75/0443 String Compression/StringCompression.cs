/*  
    Problem
    --------------------------------------------------------------------------------
    443. String Compression
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 127 ms (Beats 62.71% of users with C#)
    - Memory 62.90 MB (Beats 83.06% of users with C#)
*/

// Editorial
public class Solution
{
    public int Compress(char[] chars)
    {
        var index = 0;
        var position = 0;

        while (index < chars.Length)
        {
            var consecutive = 1;

            while (index + consecutive < chars.Length
                && chars[index + consecutive] == chars[index])
            {
                consecutive++;
            }

            chars[position++] = chars[index];

            if (consecutive > 1)
            {
                foreach (var character in consecutive.ToString())
                {
                    chars[position++] = character;
                }
            }

            index += consecutive;
        }

        return position;
    }
}
