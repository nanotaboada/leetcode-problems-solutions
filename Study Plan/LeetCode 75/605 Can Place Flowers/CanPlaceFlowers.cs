/*  
    Problem
    --------------------------------------------------------------------------------
    605. Can Place Flowers
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 102 ms (Beats 51.22% of users with C#)
    - Memory 45.76 MB (Beats 55.42% of users with C#)
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

            if (isPreviousPlotEmpty && isCurrentPlotEmpty && isNextPlotEmpty)
            {
                // plant a flower in the plot
                flowerbed[plot] = 1;
                // decrease remaining flowers
                n--;
            }
        }
        
        return n <= 0;
    }
}