/*  
    Problem
    --------------------------------------------------------------------------------
    933. Number of Recent Calls
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 22 ms (Beats 48.70% of users with Java)
    - Memory 55.82 MB (Beats 6.59% of users with Java)

*/

public class RecentCounter {
    // Represents a first-in, first-out (FIFO) collection of objects.
    private final Deque<Integer> requests;

    public RecentCounter() {
        requests = new ArrayDeque<>();
    }

    public int ping(int t) {
        // .offer() adds an object to the end of the Queue.
        requests.offer(t);
        // .peek() returns the object at the beginning of the Queue
        // without removing it.
        while (!requests.isEmpty() && requests.peek() < t - 3000) {
            // .poll() removes and returns the object at the beginning
            // of the Queue.
            requests.poll();
        }
        return requests.size();
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.ping(t);
 */