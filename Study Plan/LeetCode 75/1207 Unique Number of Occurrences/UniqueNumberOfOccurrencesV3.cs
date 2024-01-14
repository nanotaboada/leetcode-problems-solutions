/*
    Problem
    --------------------------------------------------------------------------------
    1207. Unique Number of Occurrences
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 67 ms (Beats 94.59% of users with C#)
    - Memory 42.27 MB (Beats 24.47% of users with C#)
*/

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        // Hint 1
        // Find the number of occurrences of each element in the array
        // using a hash map.
        var occurrences = new Dictionary<int, int>();

        foreach (var element in arr)
        {
            if (occurrences.ContainsKey(element))
            {
                occurrences[element]++;
            }
            else
            {
                occurrences[element] = 1;
            }
        }

        var uniques = new HashSet<int>();

        // Hint 2
        // Iterate through the hash map and check if there is a repeated value.
        foreach (var occurrence in occurrences.Values)
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