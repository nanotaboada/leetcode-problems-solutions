/*  
    Problem
    --------------------------------------------------------------------------------
    380. Insert Delete GetRandom O(1)
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    
*/

public class RandomizedSet
{
    HashSet<int> set = new();
    Random random = new();

    // Average-case Time Complexity O(1)
    public bool Insert(int val)
    {
        return set.Add(val);
    }

    // Average-case Time Complexity O(1)
    public bool Remove(int val)
    {
        return set.Remove(val);
    }

    // Average-case Time Complexity O(n)
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