/*  
    Problem
    --------------------------------------------------------------------------------
    605. Can Place Flowers
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 2 ms (Beats 7.13% of users with Java)
    - Memory 45.20 MB (Beats 7.08% of users with Java)
*/

class Solution {
    public boolean canPlaceFlowers(int[] flowerbed, int n) {
        for (int plot = 0; plot < flowerbed.length; plot++) {            
            boolean isPreviousPlotEmpty = getElementAtOrDefault(flowerbed, plot-1) == 0;
            boolean isCurrentPlotEmpty = flowerbed[plot] == 0;
            boolean isNextPlotEmpty = getElementAtOrDefault(flowerbed, plot+1) == 0;
            if (isPreviousPlotEmpty && isCurrentPlotEmpty && isNextPlotEmpty) {
                // plant a flower in the plot
                flowerbed[plot] = 1;
                // decrease remaining flowers
                n--;
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