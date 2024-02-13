/*  
    Problem
    --------------------------------------------------------------------------------
    11. Container With Most Water
*/

/*  
    Solution
    --------------------------------------------------------------------------------
        height = [ 1, 8, 6, 2, 5, 4, 8, 3, 7 ]

       |
    8 _|             8                                  8
       |             |                                  |
    7 _|             |                                  |             7
       |             |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~|
    6 _|             |~~~~~~6~~~~~~~~~~~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~|
       |             |~~~~~~|~~~~~~~~~~~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~|
    5 _|             |~~~~~~|~~~~~~~~~~~~~5~~~~~~~~~~~~~|~~~~~~~~~~~~~|
       |             |~~~~~~|~~~~~~~~~~~~~|~~~~~~~~~~~~~|~~~~~~~~~~~~~|
    4 _|             |~~~~~~|~~~~~~~~~~~~~|~~~~~~4~~~~~~|~~~~~~~~~~~~~|
       |             |~~~~~~|~~~~~~~~~~~~~|~~~~~~|~~~~~~|~~~~~~~~~~~~~|
    3 _|             |~~~~~~|~~~~~~~~~~~~~|~~~~~~|~~~~~~|~~~~~~3~~~~~~|
       |             |~~~~~~|~~~~~~~~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|
    2 _|             |~~~~~~|~~~~~~2~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|
       |             |~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|
    1 _|      1      |~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|
       |      |      |~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|~~~~~~|
    0 _|------|------|------|------|------|------|------|------|------|------

                                   container = 7 x 7 = 49

   - Runtime 5 ms (Beats 70.99% of users with Java)
   - Memory 57.99 MB (Beats 43.27% of users with Java)
*/

class Solution {
   public int maxArea(int[] height) {
      int container = 0;
      // Start with the leftmost and rightmost endpoints
      int left = 0;
      int right = height.length - 1;
      // Loop inwards (left --> <-- right)
      while (left < right) {
         // Calculate the area (area = length * width)
         int length = Math.min(height[left], height[right]);
         int width = (right - left);
         int area = length * width;
         // Update the container with the maximum area
         container = Math.max(area, container);
         // Discard the smaller endpoint (height) for the next loop
         if (height[left] < height[right]) {
         left++;
         } else {
         right--;
         }
      }
      return container;
   }
}