/*  
    Problem
    --------------------------------------------------------------------------------
    345. Reverse Vowels of a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 8 ms (Beats 28.09% of users with Java)
    - Memory 44.90 MB (Beats 38.85% of users with Java)
*/

public class Solution {
    public String reverseVowels(String s) {
        StringBuilder text = new StringBuilder(s.length());
        Deque<Character> vowels = new ArrayDeque<>();
        for (int index = 0; index < s.length(); index++) {
            char letter = s.charAt(index);
            if (isVowel(letter)) {
                vowels.push(letter);
            }
        }
        for (int index = 0; index < s.length(); index++) {
            char letter = s.charAt(index);
            if(isVowel(letter)) {
                text.append(vowels.pop());
            } else {
                text.append(letter);
            }
        }
        return text.toString();
    }
    public boolean isVowel(char letter) {
        return "aeiouAEIOU".indexOf(letter) > -1;
    }
}
