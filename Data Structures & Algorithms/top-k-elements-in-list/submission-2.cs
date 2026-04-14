public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();

        List<int>[] freq = new List<int>[nums.Length + 1];

        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        foreach (int n in nums) {
            if (count.ContainsKey(n)) {
                count[n]++;
            }
            else {
                count[n] = 1;
            }
        }

        foreach (var entry in count) {
            freq[entry.Value].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0;
        // i < k : Stop once the top K reaches for optimizing
        for (int i = freq.Length - 1; i > 0 && index < k; i--) {
            foreach (int f in freq[i]) {
                res[index++] = f;
                if (index == k) {
                    return res;
                }
            }
        }
        return res;
    }
}
