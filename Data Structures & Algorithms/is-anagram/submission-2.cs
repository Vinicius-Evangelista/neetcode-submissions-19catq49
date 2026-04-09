public class Solution {
 public bool IsAnagram(string s, string t) {
    if (s.Length != t.Length) return false;

    var count = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
        if (!count.ContainsKey(s[i])) count[s[i]] = 0;
        if (!count.ContainsKey(t[i])) count[t[i]] = 0;

        count[s[i]]++;
        count[t[i]]--;
    }

    return count.Values.All(x => x == 0);
}
    
}