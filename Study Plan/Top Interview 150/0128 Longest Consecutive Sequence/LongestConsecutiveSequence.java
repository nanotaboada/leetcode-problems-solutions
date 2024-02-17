/*  
    Problem
    --------------------------------------------------------------------------------
    128. Longest Consecutive Sequence
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 26 ms (Beats 74.21% of users with Java)
    - Memory 67.86 MB (Beats 7.44% of users with Java)
*/

public class Solution {
    public int longestConsecutive(int[] nums) {
        int longest = 0;
        if (nums.length == 0) return 0;
        // We use a HashMap to store the numbers (without duplicates) as well as
        // for efficient lookups
        HashSet<Integer> numbers = new HashSet<>();
        // In Java, unlike C#, there isn't a direct way to initialize a HashSet
        // with an array's elements in a single line. Therefore, we need to loop
        // through the array and add each element individually to the HashSet.
        for (int number : nums) {
            numbers.add(number);
        }
        for (int number : numbers) {
            // Check if the current number is the start of a potential sequence
            if (!numbers.contains(number - 1)) {
                int length = 1;
                int element = number;
                // Traverse the sequence while it contains the next consecutive
                // element
                while (numbers.contains(element + 1)) {
                    element++;
                    length++;
                }
                // Update the longest sequence if the current length is longer
                longest = Math.max(longest, length);
            }
        }
        return longest;
    }
}
