/*  
    Problem
    --------------------------------------------------------------------------------
    242. Valid Angram
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/valid-anagram/solutions/4649560/c-beats-87-in-runtime-time-complexity-o-n-log-n-introspective-sort/
    
    - Runtime 58 ms (Beats 87.36% of users with C#)
    - Memory 42.54 MB (Beats 17.00% of users with C#)
*/

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        var source = s.ToCharArray();
        var target = t.ToCharArray();

        /*
            This method uses the Introspective Sort (Introsort) algorithm as
            follows:

            - If the partition size is less than or equal to 16 elements, it
            uses an Insertion Sort algorithm.

            - If the number of partitions exceeds 2 log(n), where n is the range
            of the input array, it uses a Heapsort algorithm.

            - Otherwise, it uses a Quicksort algorithm.
            This implementation performs an unstable sort; that is, if two
            elements are equal, their order might not be preserved.
            In contrast, a stable sort preserves the order of elements that are
            equal.
            This method is an O(n log(n)) operation, where n is length.

            https://learn.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-8.0
        */
        Array.Sort(source);
        Array.Sort(target);

        return new string(source) == new string(target);
    }
}
