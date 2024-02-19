/*  
    Problem
    --------------------------------------------------------------------------------
    345. Reverse Vowels of a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 3 ms (Beats 82.77% of users with Java)
    - Memory 44.71 MB (Beats 72.44% of users with Java)
*/

public class Solution {
    public String reverseVowels(String s) {
        char[] text = s.toCharArray();
        int left = 0;
        int right = s.length() - 1;
        // Loop inwards (left --> <-- right)
        while (left < right) {
            // Find left vowel
            while (left < right
                && !isVowel(text[left])) {
                left++;
            }
            // Find right vowel
            while (left < right
                && !isVowel(text[right])) {
                right--;
            }
            // Swap left and right vowels
            if (left < right) {
                char vowel = text[left];
                text[left] = text[right];
                text[right] = vowel;
                left++;
                right--;
            }
        }
        return new String(text);
    }
    public boolean isVowel(char letter) {
        return "aeiouAEIOU".indexOf(letter) > -1;
    }
}

