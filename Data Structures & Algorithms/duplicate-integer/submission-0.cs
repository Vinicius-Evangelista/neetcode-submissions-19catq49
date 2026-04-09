public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numbersDict = new HashSet<int>();

        foreach(var num in nums)
        {
            if(!numbersDict.Add(num))
            {
                return true;
            }
        }

        return false;

    }
}