public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var map = new Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            var count = new int[26];

            foreach(char c in s)
            {
                count[c - 'a']++;
            }

            var key = string.Join(',', count);

            if(!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }

            map[key].Add(s);
        }

        return map.Values.ToList();
    }
}
