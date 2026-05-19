public class Solution {
    public int MaxProfit(int[] prices) {

    if (prices.Length == 0)
        return 0;

    var right = 1;
    var left = 0;

    var result = 0;

    while(right < prices.Length)
    {
        if(prices[right] > prices[left])
        {
            result = Math.Max(result, prices[right] - prices[left]);
        }
        else
        {
            left = right;
        }
        
        right++;
    }

    return result;
    }
}
