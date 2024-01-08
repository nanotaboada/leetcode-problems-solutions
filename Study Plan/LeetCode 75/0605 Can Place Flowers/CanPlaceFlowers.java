/*  
    Problem
    --------------------------------------------------------------------------------
    605. Can Place Flowers
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/can-place-flowers/solutions/4529149/java-time-complexity-o-n-space-complexity-o-1-beats-98-in-runtime/
    
    - Runtime 1 ms (Beats 98.39% of users with Java)
    - Memory 45.10 MB (Beats 29.62% of users with Java)
*/

class Solution {
    public boolean canPlaceFlowers(int[] flowerbed, int n) {
        for (int plot = 0; plot < flowerbed.length; plot++) {
            boolean isPreviousPlotEmpty = getElementAtOrDefault(flowerbed, plot-1) == 0;
            boolean isCurrentPlotEmpty = flowerbed[plot] == 0;
            boolean isNextPlotEmpty = getElementAtOrDefault(flowerbed, plot+1) == 0;
            // Check if the previous, current and next plots are empty
            if (isPreviousPlotEmpty && isCurrentPlotEmpty && isNextPlotEmpty) {
                // Plant a flower in the plot
                flowerbed[plot] = 1;
                // Decrease remaining flowers
                n--;
                // Early return
                if (n <= 0) return true;
            }
        }
        return n <= 0;
    }
    private static int getElementAtOrDefault(int[] array, int index) {
        if (index >= 0 && index < array.length) {
            return array[index];
        } else {
            return 0;
        }
    }
}