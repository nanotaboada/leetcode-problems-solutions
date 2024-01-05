/*  
    Problem
    --------------------------------------------------------------------------------
    219. Contains Duplicate II
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 17 ms (Beats 78.83% of users with Java)
    - Memory 56.07 MB (Beats 70.51% of users with Java)
*/

class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        HashMap<Integer,Integer> numberAndIndex = new HashMap<>();
        for (int index = 0; index < nums.length; index++) {
            int number = nums[index];
            if (!numberAndIndex.containsKey(number)) {
                numberAndIndex.put(number, index);
            } else {
                if (Math.abs(numberAndIndex.get(number) - index) <= k) {
                    return true;
                } else {
                    numberAndIndex.put(number, index);
                }
            }
        }
        return false;
    }
}
