/*  
    Problem
    --------------------------------------------------------------------------------
    380. Insert Delete GetRandom O(1)
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/insert-delete-getrandom-o1/solutions/4477029/c-average-case-time-complexity-o-1-hashset-and-list-straightforward-approach/
*/

public class RandomizedSet
{
    HashSet<int> set = new();
    Random random = new();
    List<int> list = new();
    
    // Average-case Time Complexity O(1)
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
    
    // Average-case Time Complexity O(1)
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

    // Average-case Time Complexity O(1)
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