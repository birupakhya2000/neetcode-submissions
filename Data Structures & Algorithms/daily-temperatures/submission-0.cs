public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] arr = new int[n];

        Stack<int> stack = new(); 
        for(int i =0; i< n; i++)
        {
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int previousDay = stack.Pop();
                arr[previousDay] = i - previousDay;
            }
            stack.Push(i);
        }
        return arr;
    }
}
