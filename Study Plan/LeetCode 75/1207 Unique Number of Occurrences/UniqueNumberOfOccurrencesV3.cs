/*
    Problem
    --------------------------------------------------------------------------------
    1207. Unique Number of Occurrences
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/unique-number-of-occurrences/solutions/4643870/c-based-on-hints-beats-95-in-runtime-time-and-space-complexity-o-n/

    - Runtime 61 ms (Beats 95.05% of users with C#)
    - Memory 41.85 MB (Beats 89.02% of users with C#)
*/

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        // Hint 1
        // Find the number of occurrences of each element in the array
        // using a hash map.
        var occurrences = new Dictionary<int, int>(arr.Length);

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