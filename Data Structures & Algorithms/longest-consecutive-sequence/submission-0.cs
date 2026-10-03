public class Solution {
    public int LongestConsecutive(int[] nums) {
        int longest = 0;
        HashSet<int> set = new HashSet<int>(nums);

        foreach(int num in set)
        {
            if(!set.Contains(num - 1))
            {
                int current = num;
                int count = 1;

                while(set.Contains(current + 1))
                {
                    current++;
                    count++;
                } 

                longest = int.Max(longest,count);
            }
        }
        return longest;
    }
}
