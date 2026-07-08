public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] counter = new int[26];

        foreach (char ch in magazine) counter[ch - 'a']++;

        foreach (char ch in ransomNote) {
            if (--counter[ch - 'a'] < 0)
                return false;
        }

        return true;
    }
}