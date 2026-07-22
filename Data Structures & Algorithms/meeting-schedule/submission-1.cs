/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {

        if (intervals.Count == 0 )
            return true;

        intervals.Sort((a,b) => a.start.CompareTo(b.start));

        for(int i = 0; i < intervals.Count - 1; i++)
        {
            if(intervals[i + 1].start < intervals[i].end)
                return false;
        }

        return true;
    }
}
