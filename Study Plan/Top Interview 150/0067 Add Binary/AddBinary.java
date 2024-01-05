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

    - Runtime 2 ms (Beats 62.32% of users with Java)
    - Memory 42.00 MB (Beats 36.52% of users with Java)
*/

class Solution {
    public String addBinary(String a, String b) {
        StringBuilder binary = new StringBuilder();
        int i = a.length() - 1;
        int j = b.length() - 1;
        int carry = 0;
        while (i >= 0 || j >= 0 || carry > 0) {
            int sum = carry;
            if (i >= 0) sum += Character.getNumericValue(a.charAt(i));
            if (j >= 0) sum += Character.getNumericValue(b.charAt(j));
            binary.append(sum % 2);
            carry = sum / 2;
            i--;
            j--;
        }
        return binary.reverse().toString();
    }
}
