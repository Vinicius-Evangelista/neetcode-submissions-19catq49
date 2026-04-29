public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        var set = new HashSet<int>(nums);
        int longest = 0;

        foreach(int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int length = 1;

                while(set.Contains(num + length))
                {
                    length++;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
