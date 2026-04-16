public class Solution {

    public string Encode(IList<string> strs) {

        const string delim = "#";
        var sb = new StringBuilder(200);

        foreach(var s in strs)
        {
            var length = s.Length;
            sb.Append(length).Append(delim).Append(s);  
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {

        List<string> strs = new ();

        int start = 0;
        var sSpan = s.AsSpan();

        while(start < s.Length)
        {
            int hashIndex = s.IndexOf('#', start);
            int count = int.Parse(s[start..hashIndex]);
            strs.Add(s[(hashIndex + 1)..(hashIndex + 1 + count)]);
            start = hashIndex + 1 + count;
        }

        return strs;
   }
}
