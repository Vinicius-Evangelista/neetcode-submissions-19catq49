public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        if(nums.Length < 2)
            return [];
        
        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        { 
            var difference = target - nums[i];

            if(map.TryGetValue(difference, out int value))
            {
                return [value, i];
            }    

            map.Add(nums[i], i);
        }    
        
        return [-1, -1];
    }
}
