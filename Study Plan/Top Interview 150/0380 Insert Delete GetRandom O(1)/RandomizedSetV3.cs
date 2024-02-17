/*  
    Problem
    --------------------------------------------------------------------------------
    380. Insert Delete GetRandom O(1)
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/insert-delete-getrandom-o1/solutions/4477029/c-beats-62-in-runtime-and-75-in-memory-time-complexity-o-1-dictionary-and-list/

    - Runtime 327 ms (Beats 62.67% of users with C#)
    - Memory 115.84 MB (Beats 75.37% of users with C#)
*/

public class RandomizedSet
{
    Dictionary<int, int> itemsAndIndices;
    List<int> items;
    Random random;

public class RandomizedSet
{
    List<int> items; // Stores the list of items
    Dictionary<int, int> itemsAndIndices; // Maps items to their indices
    Random random; // Random number generator

    public RandomizedSet()
    {
        items = new List<int>();
        itemsAndIndices = new Dictionary<int, int>();
        random = new Random();
    }
    
    /*
        Inserts a value into the set if it doesn't already exist.
        Returns true if the value was successfully inserted, false otherwise.
        Time Complexity: O(1)
    */
    public bool Insert(int val)
    {
        // If the value is not already present in the set
        if (!itemsAndIndices.ContainsKey(val))
        {
            // Map value to its index
            itemsAndIndices[val] = items.Count;
            // Add the value to the list
            items.Add(val);

            return true;
        }

        return false;
    }

    /* 
        Removes a value from the set if it exists.
        Returns true if the value was successfully removed, false otherwise.
        Time Complexity: O(1)
    */
    public bool Remove(int val)
    {
        // If the value exists in the set
        if (itemsAndIndices.TryGetValue(val, out int index))
        {
            // Replace the item at index with the last item in the list
            var lastItem = items[items.Count - 1];
            items[index] = lastItem;
            // Update index of lastItem in the dictionary
            itemsAndIndices[lastItem] = index;
            // Remove the last item from the list
            items.RemoveAt(items.Count - 1);
            // Remove the value from the dictionary
            itemsAndIndices.Remove(val);

            return true;
        }

        return false;
    }

    /* 
        Returns a random element from the set.
        Time Complexity: O(1)
    */
    public int GetRandom()
    {
        // Generate a random index within the range of the list
        return items[random.Next(items.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
