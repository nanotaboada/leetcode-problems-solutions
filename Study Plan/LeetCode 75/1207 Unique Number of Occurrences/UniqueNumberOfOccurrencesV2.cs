/*
    Problem
    --------------------------------------------------------------------------------
    1207. Unique Number of Occurrences
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 101 ms (Beats 5.70% of users with C#)
    - Memory 40.48 MB (Beats 31.96% of users with C#)
*/

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var occurrenceOfElements = arr
            .GroupBy(element => element)
            .Select(group => new {
                Element = group.Key,
                Occurrence = group.Count()
            });

        var numberOfOccurrences = occurrenceOfElements
            .GroupBy(element => element.Occurrence)
            .Select(group => group.Count());

        var uniqueOcurrences = numberOfOccurrences
            .All(occurrence => occurrence == 1);
        
        return uniqueOcurrences;
    }
}