public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var freq = new Dictionary<int, int>();
        var heap = new PriorityQueue<int, int>();
        var res = new List<int>();

        foreach(var num in nums)
        {
            freq[num] = freq.GetValueOrDefault(num, 0) + 1;
        }

        foreach(var kv in freq)
        {
            heap.Enqueue(kv.Key, kv.Value);

              if (heap.Count > k)
                heap.Dequeue();
        }   

        var result = new List<int>();

        while (heap.Count > 0)
        {
            result.Add(heap.Dequeue());
        }

        return result.ToArray();
    }
}
