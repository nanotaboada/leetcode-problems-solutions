/*  
    Problem
    --------------------------------------------------------------------------------
    383. Ransom Note
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 10 ms (Beats 59.10% of users with Java)
    - Memory 44.99 MB (Beats 5.76% of users with Java)
*/

class Solution {
    public boolean canConstruct(String ransomNote, String magazine) {
        char[] ransomNoteLetters = ransomNote.toCharArray();
        char[] magazineLetters = magazine.toCharArray();
        Map<Character, Integer> lettersFromMagazine = new HashMap<>();
        // Create a map of letters from the magazine, where the Key is a letter
        // and the Value is the count of occurrences of each letter
        for (char letter : magazineLetters) {
            lettersFromMagazine.put(letter, lettersFromMagazine.getOrDefault(letter, 0) + 1);
        }
        // Check if the ransomNote can be constructed using the letters
        // from the magazine, looking for each letter in the collection
        for (char letter : ransomNoteLetters) {
            int occurrences = lettersFromMagazine.getOrDefault(letter, 0);
            if (occurrences <= 0) {
                // The letter is not available, or has already been used
                return false;
            }
            // One letter has been used to construct the ransomNote, so it needs
            // to be removed the collection of available letters
            lettersFromMagazine.put(letter, occurrences - 1);
        }
        // The ransomNote can be constructed
        return true;
    }
}