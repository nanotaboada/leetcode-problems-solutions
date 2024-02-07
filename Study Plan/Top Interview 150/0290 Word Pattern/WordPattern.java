/*  
    Problem
    --------------------------------------------------------------------------------
    290. Word Pattern
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 1 ms (Beats 86.93% of users with Java)
    - Memory 41.22 MB (Beats 16.68% of users with Java)
*/

class Solution {
    public boolean wordPattern(String pattern, String s) {
        String[] words = s.split(" ");
        if (pattern.length() != words.length) return false;
        HashMap<Character,String> letterToWord = new HashMap<>(pattern.length());
        HashMap<String,Character> wordToLetter = new HashMap<>(words.length);
        for (var index = 0; index < pattern.length(); index++) {
            char letter = pattern.charAt(index);
            String word = words[index];
            if (!letterToWord.containsKey(letter)) {
                letterToWord.put(letter, word);
            }
            if (!wordToLetter.containsKey(word)) {
                wordToLetter.put(word, letter);
            }
            if (!letterToWord.get(letter).equals(word)
                || !wordToLetter.get(word).equals(letter)) {
                return false;
            }
        }
        return true;
    }
}