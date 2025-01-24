namespace Algorithm.BOJ.BOJ_01725
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01725/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int[] heights = new int[N];
            Stack<int> stack = new();
            int si;
            int max = 0;

            for (int i = 0; i < N; i++)
            {
                heights[i] = int.Parse(Console.ReadLine()!);

                while (stack.TryPeek(out si) && heights[si] >= heights[i])
                {
                    int height = heights[stack.Pop()];
                    int width = stack.TryPeek(out si) ? i - si - 1 : i;
                    max = Math.Max(max, height * width);
                }

                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                int height = heights[stack.Pop()];
                int width = stack.TryPeek(out si) ? N - si - 1 : N;
                max = Math.Max(max, height * width);
            }

            Console.WriteLine(max);
        }
    }
}
