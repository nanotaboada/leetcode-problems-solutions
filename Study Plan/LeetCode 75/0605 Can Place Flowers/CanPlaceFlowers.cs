/*  
    Problem
    --------------------------------------------------------------------------------
    605. Can Place Flowers
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 107 ms (Beats 41.56% of users with C#)
    - Memory 48.43 MB (Beats 5.72% of users with C#)
*/

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        for (int plot = 0; plot < flowerbed.Length; plot++)
        {
            // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.elementatordefault
            
            var isPreviousPlotEmpty = flowerbed.ElementAtOrDefault(plot-1) == 0;
            var isCurrentPlotEmpty = flowerbed[plot] == 0;
            var isNextPlotEmpty = flowerbed.ElementAtOrDefault(plot+1) == 0;

            // Check if the previous, current and next plots are empty
            if (isPreviousPlotEmpty && isCurrentPlotEmpty && isNextPlotEmpty)
            {
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
}