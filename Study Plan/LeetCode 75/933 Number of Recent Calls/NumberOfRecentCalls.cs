/*  
    Problem
    --------------------------------------------------------------------------------
    933. Number of Recent Calls
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 225 ms (Beats 100.00% of users with C#)
    - Memory 102.04 MB (Beats 11.80% of users with C#)
*/

public class RecentCounter
{
    // Represents a first-in, first-out (FIFO) collection of objects.
    private readonly Queue<int> requests;

    public RecentCounter()
    {
        requests = new Queue<int>();
    }

    public int Ping(int t)
    {
        // .Enqueue(T) adds an object to the end of the Queue<T>.
        requests.Enqueue(t);

        // .Peek() returns the object at the beginning of the Queue<T>
        // without removing it.
        while (requests.Peek() < t - 3000)
        {
            // .Dequeue() removes and returns the object at the beginning
            // of the Queue<T>.
            requests.Dequeue();
        }
        
        return requests.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */