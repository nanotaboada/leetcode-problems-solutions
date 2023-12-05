/*  
    Problem
    --------------------------------------------------------------------------------
    191. Number of 1 Bits
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 16 ms (Beats 90.75% of users with C#)
    - Memory 23.97 MB (Beats 35.42% of users with C#)
*/
public class Solution
{
    public int HammingWeight(uint n)
    {
        return BitOperations.PopCount(n);    
    }
}
/*
    Discussion
    --------------------------------------------------------------------------------
    Honestly I don't understand why LeetCode promotes these types of problems
    to make us reinvent the wheel. This type of elemental operations are
    already implemented in most modern frameworks and languages by people much
    smarter than us, who invested their time and resources, precisely so that
    we don't have to do it again.

    The BitOperations.PopCount method (Assembly: System.Runtime.dll) already
    beats 90.75% of accepted submissions in C#.

    The developer community should not accept wasting our time on this.
*/