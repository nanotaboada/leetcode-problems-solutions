/*  
    Problem
    --------------------------------------------------------------------------------
    205. Isomorphic Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 11 ms (Beats 52.22% of users with Java)
    - Memory 42.59 MB (Beats 11.58% of users with Java)
*/

class Solution {
    public boolean isIsomorphic(String s, String t) {
        if (s.length() != t.length()) {
            return false;
        }
        // map of source (Key) and target (Value) characters
        var charMap = new HashMap<Character, Character>();
        // set of characters that have already been mapped
        var charSet = new HashSet<Character>();
        for (var i = 0; i < s.length(); i++) {
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
                // add the target character to the set of alreaady mapped
                charSet.add(target);
            }
        }
        return true;
    }
}