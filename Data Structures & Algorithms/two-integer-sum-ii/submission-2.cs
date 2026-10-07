public class Solution {
     public int[] TwoSum(int[] numbers, int target)
    {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < numbers.Length; i++)
        {
            int missing = target - numbers[i];

            if (dict.ContainsKey(missing))
            {
                return new int[] { dict[missing] + 1, i + 1 };
            }

            dict[numbers[i]] = i;
        }

        return Array.Empty<int>();
    }
}
