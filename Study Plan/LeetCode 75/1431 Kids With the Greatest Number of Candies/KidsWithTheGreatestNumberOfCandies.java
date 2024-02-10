/*  
    Problem
    --------------------------------------------------------------------------------
    1431. Kids With the Greatest Number of Candies
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 4 ms (Beats 6.88% of users with Java)
    - Memory 42.60 MB (Beats 15.27% of users with Java)
*/

class Solution {
    public List<Boolean> kidsWithCandies(int[] candies, int extraCandies) {
        int maxCandies = Arrays.stream(candies).max().orElse(0);
        return Arrays.stream(candies)
            .mapToObj(kid -> kid + extraCandies >= maxCandies)
            .collect(Collectors.toList());
    }
}

