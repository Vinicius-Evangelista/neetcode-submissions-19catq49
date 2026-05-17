public class Solution {
    public int MaxArea(int[] heights) {
        
        var maxAmount = 0;

        var left = 0;
        var right = heights.Length - 1;

        while(right > left)
        {
            var h1 = heights[left];
            var h2 = heights[right];

            var areaDifference = Math.Min(h1, h2);
            maxAmount = Math.Max(maxAmount, areaDifference * (right - left));

            if (h1 == h2)
            {
                left++;
                right--;
            }
            else if (h1 > h2)
                right--;
            else
                left++;
        }        

        return maxAmount;
    }
}
