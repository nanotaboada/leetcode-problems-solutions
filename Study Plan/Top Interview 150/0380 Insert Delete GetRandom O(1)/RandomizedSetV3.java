/*  
    Problem
    --------------------------------------------------------------------------------
    380. Insert Delete GetRandom O(1)
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 22 ms (Beats 99.06% of users with Java)
    - Memory 91.44 MB Beats 63.64% of users with Java)
*/

class RandomizedSet {

    private List<Integer> items;
    private Map<Integer, Integer> itemsAndIndices;
    private Random random;

    public RandomizedSet() {
        items = new ArrayList<>();
        itemsAndIndices = new HashMap<>();
        random = new Random();
    }
    
    // Time Complexity: O(1)
    public boolean insert(int val) {
        if (!itemsAndIndices.containsKey(val)) {
            itemsAndIndices.put(val, items.size());
            items.add(val);
            return true;
        }
        return false;
    }
    
    // Time Complexity: O(1)
    public boolean remove(int val) {
        if (itemsAndIndices.containsKey(val)) {
            int index = itemsAndIndices.get(val);
            int lastItem = items.get(items.size() - 1);
            items.set(index, lastItem);
            itemsAndIndices.put(lastItem, index);
            items.remove(items.size() - 1);
            itemsAndIndices.remove(val);
            return true;
        }
        return false;
    }
    
    // Time Complexity: O(1)
    public int getRandom() {
        return items.get(random.nextInt(items.size()));
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * boolean param_1 = obj.insert(val);
 * boolean param_2 = obj.remove(val);
 * int param_3 = obj.getRandom();
 */
