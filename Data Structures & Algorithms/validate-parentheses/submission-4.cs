public class Solution {
    public bool IsValid(string s) {
        if (string.IsNullOrEmpty(s))
            return true;
        
        if (s.Length % 2 == 1) return false;

        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>()
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        foreach (var ch in s) {
            
            if (dict.ContainsKey(ch))
            {
                stack.Push(ch); 
            }    
            else
            {
                if (stack.Count == 0) return false;

                var item = stack.Pop();
                
                if (!(dict.TryGetValue(item, out var value) && value == ch))
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
