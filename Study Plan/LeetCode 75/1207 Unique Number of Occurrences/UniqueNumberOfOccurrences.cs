/*
    Problem
    --------------------------------------------------------------------------------
    1207. Unique Number of Occurrences
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 97 ms (Beats 16.05% of users with C#)
    - Memory 40.49 MB (Beats 31.96% of users with C#)
*/

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        // Hint 1
        // Find the number of occurrences of each element in the array
        var occurrences = arr
            .GroupBy(element => element)
            .Select(group => group.Count());

        // using a hash map
        var uniques = new HashSet<int>();

        // Hint 2
        // Iterate through the hash map and check if there is a repeated value.
        foreach (var occurrence in occurrences)
        {
            // Returns true if the element is added to the HashSet<T> object,
            // false if the element is already present.
            // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1.add
            if(!uniques.Add(occurrence))
            {
                return false;
            }
        }

        return true;
    }
}