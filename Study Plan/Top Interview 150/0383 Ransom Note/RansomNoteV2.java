/*  
    Problem
    --------------------------------------------------------------------------------
    383. Ransom Note
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 10 ms (Beats 57.60% of users with Java)
    - Memory 45.18 MB (Beats 28.54% of users with Java)
*/

class Solution {
    public boolean canConstruct(String ransomNote, String magazine) {
        // Early return if ransomNote is longer than magazine
        if (ransomNote.length() > magazine.length()) {
            return false;
        }
        HashMap<Character, Integer> lettersFromMagazine = new HashMap<>();
        // Count the occurrences of each letter in the magazine
        for (char letter : magazine.toCharArray()) {
            lettersFromMagazine.put(letter, lettersFromMagazine.getOrDefault(letter, 0) + 1);
        }
        // Check if the ransom note can be constructed using the letters from
        // the magazine
        for (char letter : ransomNote.toCharArray()) {
            if (!lettersFromMagazine.containsKey(letter) 
                || lettersFromMagazine.get(letter) == 0) {
                return false;
            }
            lettersFromMagazine.put(letter, lettersFromMagazine.get(letter) - 1);
        }
        return true;
    }
}
