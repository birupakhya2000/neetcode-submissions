public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;

        var cars = Enumerable.Range(0, n)
                       .Select(i => new { Position = position[i], Speed = speed[i] })
                       .OrderByDescending(car => car.Position)
                       .ToArray();
        Stack<double> stack = new Stack<double>();
        foreach (var car in cars) {
            double time = (double)(target - car.Position) / car.Speed;

            if (stack.Count == 0 || time > stack.Peek())
            {
                stack.Push(time);
            }
        }
        return stack.Count;
    }
}
