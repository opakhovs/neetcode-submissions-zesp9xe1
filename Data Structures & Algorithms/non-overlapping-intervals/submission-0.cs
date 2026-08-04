public class Solution {
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int removed = 0;
        int previousEnd = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < previousEnd)
            {
                removed++;
            }
            else
           {
               previousEnd = intervals[i][1];
           }
        }

        return removed;
    }
}