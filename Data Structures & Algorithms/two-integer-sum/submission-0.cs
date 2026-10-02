public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i =0; i<= nums.Length; i++)
        {
            int missing = target - nums[i];
            if(dict.ContainsKey(missing))
                return new int[]{dict[missing],i};
            
            dict[nums[i]]=i;
        }
        return Array.Empty<int>();
    }
}
