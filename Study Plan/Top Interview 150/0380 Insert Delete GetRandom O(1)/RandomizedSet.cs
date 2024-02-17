/*  
    Problem
    --------------------------------------------------------------------------------
    380. Insert Delete GetRandom O(1)
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 946 ms (Beats 5.04% of users with C#)
    - Memory 122.16 MB (Beats 49.65% of users with C#)
*/

public class RandomizedSet
{
    HashSet<int> set = new();
    Random random = new();

    // Time Complexity O(1)
    public bool Insert(int val)
    {
        return set.Add(val);
    }

    // Time Complexity O(1)
    public bool Remove(int val)
    {
        return set.Remove(val);
    }

    // Time Complexity O(n)
    public int GetRandom()
    {
        return set.ElementAt(random.Next(maxValue: set.Count));
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */