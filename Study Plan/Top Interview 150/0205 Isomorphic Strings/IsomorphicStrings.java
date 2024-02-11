/*  
    Problem
    --------------------------------------------------------------------------------
    205. Isomorphic Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 10 ms (Beats 69.40% of users with Java)
    - Memory 43.11 MB (Beats 10.47% of users with Java)
*/

class Solution {
    public boolean isIsomorphic(String s, String t) {
        // Constraints: t.length == s.length
        int length = s.length();
        // map of source (Key) and target (Value) characters
        HashMap<Character, Character> charMap = new HashMap<>(length);
        // set of characters that have already been mapped
        HashSet<Character> charSet = new HashSet<>(length);
        for (int i = 0; i < length; i++) {
            // loop through the characters of both strings
            char source = s.charAt(i);
            char target = t.charAt(i);
            // check if the character from the source has already been mapped
            if (charMap.containsKey(source)) {
                // verify that the mapping matches
                if (charMap.get(source) != target) {
                    // inconsistency
                    return false;
                }
            // the character hasn't been mapped yet
            } else {
                // check if the character from the target has already been mapped
                if (charSet.contains(target)) {
                    // already mapped to another character
                    return false;
                }
                // add the source/target character mapping
                charMap.put(source, target);
                // add the target character to the set of already mapped
                charSet.add(target);
            }
        }
        return true;
    }
}