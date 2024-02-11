/*  
    Problem
    --------------------------------------------------------------------------------
    205. Isomorphic Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 6 ms (Beats 94.27% of users with Java)
    - Memory 42.58 MB (Beats 29.35% of users with Java)
*/

class Solution {
    public boolean isIsomorphic(String s, String t) {
        int[] sources = new int[128];
        int[] targets = new int[128];
        for (int index = 0; index < s.length(); index++) {
            char source = s.charAt(index);
            char target = t.charAt(index);
            if (sources[source] != targets[target]) {
                return false;
            }
            sources[source] = index + 1;
            targets[target] = index + 1;   
        }
        return true;
    }
}
