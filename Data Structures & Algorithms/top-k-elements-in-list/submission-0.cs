public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new();
        foreach(int num in nums)
        {
            if(dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        }

        var result = dict.OrderByDescending(x => x.Value);
        List<int> freq = new();
        int count = 0;
        foreach(var data in result)
        {
            if(count < k)
            {
                freq.Add(data.Key);
                count++;
            }
        }
        return freq.ToArray();
    }
}
