/*  
    Problem
    --------------------------------------------------------------------------------
    67. Add Binary
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    Example for a = "1011" and b = "111"

    More info: https://www.youtube.com/watch?v=RgklPQ8rbkg

            1
        1 0 1 1
      +   1 1 1
        -------    decimal: 2, binary: 10
              0    write 0, carry 1

          1 1
        1 0 1 1
      +   1 1 1
        -------     decimal: 3, binary: 11
            1 0     write 1, carry 1

        1 1 1
        1 0 1 1
      +   1 1 1
        -------     decimal: 2, binary: 10
          0 1 0     write 0, carry 1

      1 1 1 1
        1 0 1 1
      +   1 1 1
        -------     decimal: 2, binary: 10
        0 0 1 0     write 0, carry 1

      1 1 1 1
        1 0 1 1
      +   1 1 1
        -------     
      1 0 0 1 0     write 1 (nothing to add)

      - Runtime 64 ms (Beats 86.07% of users with C#)
      - Memory 40.20 MB (Beats 43.18% of users with C#)
*/

public class Solution
{
    public string AddBinary(string a, string b) 
    { 
        var binary = new StringBuilder();
        var i = a.Length - 1;
        var j = b.Length - 1;
        var carry = 0;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            var sum = carry;
            
            if (i >= 0) sum += (int)Char.GetNumericValue(a[i]);
            if (j >= 0) sum += (int)Char.GetNumericValue(b[j]);

            // In general, the Append method is expected to be faster
            // than Insert 
            binary.Append(sum % 2);
            
            carry = sum / 2;
            i--;
            j--;
        }

        return new string(binary.ToString().Reverse().ToArray());
    }
}
