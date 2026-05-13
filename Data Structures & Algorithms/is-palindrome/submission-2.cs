public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 1 || string.IsNullOrEmpty(s)) return true;

        var result = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());
        int left = 0;
        int right = result.Length - 1;

        while(right >= left)
        {
            if(result[left] != result[right])
                return false;    

            right--;
            left++;
        }

        return true;
    }
}
