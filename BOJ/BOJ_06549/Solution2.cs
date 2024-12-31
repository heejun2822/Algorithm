namespace Algorithm.BOJ.BOJ_06549
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_06549/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()!) != "0")
            {
                string[] numbers = input.Split();
                int n = int.Parse(numbers[0]);
                int[] h = new int[n];
                for (int i = 0; i < n; i++) h[i] = int.Parse(numbers[i + 1]);

                long maxExtent = 0;
                Stack<int> stack = new();
                for (int i = 0; i < n; i++)
                {
                    while (stack.Count > 0 && h[i] < h[stack.Peek()])
                    {
                        int height = h[stack.Pop()];
                        int width = stack.Count > 0 ? i - stack.Peek() - 1 : i;
                        maxExtent = Math.Max(maxExtent, (long)height * width);
                    }
                    if (stack.Count > 0 && h[i] == h[stack.Peek()]) stack.Pop();
                    stack.Push(i);
                }
                while (stack.Count > 0)
                {
                    int height = h[stack.Pop()];
                    int width = stack.Count > 0 ? n - stack.Peek() - 1 : n;
                    maxExtent = Math.Max(maxExtent, (long)height * width);
                }

                Console.WriteLine(maxExtent);
            }
        }
    }
}
