public class Solution {
    public int FindMin(int[] nums) {
        
        if (nums.Length == 1)
            return nums[0];

        var l = 0;
        var r = nums.Length - 1;

        while (l < r)
        {
            var mid = (l + r) / 2;

            if (nums[mid] > nums[r])
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return nums[l];
    }
}