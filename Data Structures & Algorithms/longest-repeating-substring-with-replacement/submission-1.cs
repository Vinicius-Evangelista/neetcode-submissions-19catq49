public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int max = 0, l = 0, res = 0;
        var dict = new Dictionary<char, int>();

        for(int r = 0; r < s.Length; r++)
        {
            if(dict.ContainsKey(s[r]))
            {
                dict[s[r]]++;
            }
            else
            {
                dict[s[r]] = 1;            
            }

            max = Math.Max(max, dict[s[r]]);

            while((r - l + 1) - max > k)
            {
                dict[s[l]]--;
                l++;
            }  

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
