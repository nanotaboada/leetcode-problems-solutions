/*  
    Problem
    --------------------------------------------------------------------------------
    151. Reverse Words in a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 8 ms (Beats 57.55% of users with Java)
    - Memory 43.00 MB (Beats 67.52% of users with Java)
*/

class Solution {
    public String reverseWords(String s) {
        List<String> words = Arrays.asList(s.split("\\s+"));
        Collections.reverse(words);
        return String.join(" ", words).trim();
    }
}