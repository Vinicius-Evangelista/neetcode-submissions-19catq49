public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var map = new Dictionary<string, List<string>>();

        foreach(string word in strs)
        {
            int[] counter = new int[26];

            foreach(char ch in word)
                counter[ch - 'a']++;
            
            string key = string.Join(",", counter);

if (map.ContainsKey(key))
    map[key].Add(word);
else
    map[key] = new List<string> { word };
        }

        return map.Values.ToList<List<string>>();
    }
}
