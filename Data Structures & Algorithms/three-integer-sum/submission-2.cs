public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var triplets = new List<List<int>>();

        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;

            if (i > 0 && nums[i - 1] == nums[i])
                continue;

            while(right > left)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (sum > 0)
                    right--;
                else if (sum == 0)
                {
                    triplets.Add([nums[i], nums[left], nums[right]]);
                    right--;
                    left++;

                        while (left < right && nums[left] == nums[left - 1])
                            left++;

                        while (left < right && nums[right] == nums[right + 1])
                            right--;
                }
                else 
                    left++;
            }
        }

        return triplets;
    }
}
