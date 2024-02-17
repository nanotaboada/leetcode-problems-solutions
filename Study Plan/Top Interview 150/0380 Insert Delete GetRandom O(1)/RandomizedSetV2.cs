/*  
    Problem
    --------------------------------------------------------------------------------
    380. Insert Delete GetRandom O(1)
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 539 ms (Beats 5.04% of users with C#)
    - Memory 122.00 MB (Beats 49.75% of users with C#)
*/

public class RandomizedSet
{
    HashSet<int> set = new();
    Random random = new();
    List<int> list = new();
    
    // Time Complexity O(1)
    public bool Insert(int val)
    {
        if (set.Add(val))
        {
            list.Add(val);
            return true;
        }
        else
        {
            return false;
        }
    }
    
    // Time Complexity O(1)
    public bool Remove(int val)
    {
        if (set.Remove(val))
        {
            list.Remove(val);
            return true;
        }
        else
        {
            return false;
        }
    }

    // Time Complexity O(1)
    public int GetRandom()
    {
        return list[random.Next(maxValue: list.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */