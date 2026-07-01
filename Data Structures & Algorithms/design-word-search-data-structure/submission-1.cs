public class TrieNode {
    public TrieNode[] children = new TrieNode[26];
    public bool word = false;
}

public class WordDictionary {
    private TrieNode root;

    public WordDictionary() {
        root = new();
    }

    public void AddWord(string word) {
        TrieNode cur = root;

        foreach (char c in word) {
            int i = c - 'a';

            if (cur.children[i] == null)
                cur.children[i] = new TrieNode();

            cur = cur.children[i];
        }

        cur.word = true;
    }

    public bool Search(string word) {
        return Dfs(word, 0, root);
    }

    private bool Dfs(string word, int j, TrieNode root) {
        TrieNode cur = root;

        for (int i = j; i < word.Length; i++) {
            char c = word[i];

            if (c == '.') {
                foreach (TrieNode child in cur.children) {
                    if (child != null && Dfs(word, i + 1, child))
                        return true;
                }

                return false;
            } else {
                int idx = c - 'a';

                if (cur.children[idx] == null)
                    return false;

                cur = cur.children[idx];
            }
        }

        return cur.word;
    }
}
