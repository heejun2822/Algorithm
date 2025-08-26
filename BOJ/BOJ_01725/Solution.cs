namespace Algorithm.BOJ.BOJ_01725
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01725/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            Stack<(int i, int h)> stack = new();
            (int i, int h) se;
            int max = 0;

            for (int i = 0; i < N; i++)
            {
                int h = int.Parse(Console.ReadLine()!);

                while (stack.TryPeek(out se) && se.h >= h)
                {
                    int height = stack.Pop().h;
                    int width = stack.TryPeek(out se) ? i - se.i - 1 : i;
                    max = Math.Max(max, height * width);
                }

                stack.Push((i, h));
            }

            while (stack.Count > 0)
            {
                int height = stack.Pop().h;
                int width = stack.TryPeek(out se) ? N - se.i - 1 : N;
                max = Math.Max(max, height * width);
            }

            Console.WriteLine(max);
        }
    }
}
