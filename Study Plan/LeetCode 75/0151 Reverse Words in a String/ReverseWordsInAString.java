/*  
    Problem
    --------------------------------------------------------------------------------
    151. Reverse Words in a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 7 ms (Beats 75.17% of users with Java)
    - Memory 42.72 MB (Beats 67.88% of users with Java)
*/

class Solution {
    public String reverseWords(String s) {
        // https://www.baeldung.com/string/split
        String[] words = s.split("\\s+", -1);
        Collections.reverse(Arrays.asList(words));
        StringBuilder reversed = new StringBuilder(words.length);
        for (String word : words) {
            reversed.append(word).append(" ");
        }
        return reversed.toString().trim();
    }
}