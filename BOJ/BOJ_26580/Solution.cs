namespace Algorithm.BOJ.BOJ_26580
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26580/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            while (n-- > 0)
            {
                int[] heights = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                Stack<int> stack = new();
                int amount = 0;

                for (int curr = 0; curr < heights.Length; curr++)
                {
                    while (stack.TryPeek(out int prev1) && heights[prev1] <= heights[curr])
                    {
                        stack.Pop();
                        if (stack.TryPeek(out int prev2))
                            amount += (Math.Min(heights[prev2], heights[curr]) - heights[prev1]) * (curr - prev2 - 1);
                    }
                    stack.Push(curr);
                }

                Console.WriteLine(amount);
            }
        }
    }
}
