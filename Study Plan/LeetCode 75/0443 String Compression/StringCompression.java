/*  
    Problem
    --------------------------------------------------------------------------------
    443. String Compression
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 1 ms (Beats 99.39% of users with Java)
    - Memory 44.04 MB (Beats 45.58% of users with Java)
*/

// Editorial
public class Solution {
    public int compress(char[] chars) {
        int index = 0;
        int position = 0;
        while (index < chars.length) {
            int consecutive = 1;
            while (index + consecutive < chars.length
                && chars[index + consecutive] == chars[index]) {
                consecutive++;
            }
            chars[position++] = chars[index];
            if (consecutive > 1) {
                for(char character : Integer.toString(consecutive).toCharArray()) {
                    chars[position++] = character;
                }
            }
            index += consecutive;
        }
        return position;
    }
}
