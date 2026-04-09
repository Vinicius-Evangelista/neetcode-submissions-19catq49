public class Solution {
 public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var map1 = new int[26];
        var map2 = new int[26];

        foreach (var c in s)
        {
            var key = c - 'a';
            map1[key] = map1[key] + 1;
        }

        foreach (var c in t)
        {
            var key = c - 'a';
            map2[key] = map2[key] + 1;
        }
        
        foreach (var c in s)
        {
            var key = c - 'a';
            if (map1[key] != map2[key])
                return false;
        }

        return true;
    }
}
