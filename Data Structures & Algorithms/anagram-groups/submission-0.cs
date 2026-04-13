public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var anagramDict = new Dictionary<string, List<string>>();
    
        foreach(var anagram in strs)
        {
            char[] arr = anagram.ToCharArray();
            Array.Sort(arr);
            string sorted = new string(arr);

            if(anagramDict.TryGetValue(sorted, out List<string> values))
                values.Add(anagram);
            else
                anagramDict[sorted] = [anagram];
        }

        return anagramDict.Values.ToList();
    
    }
}
