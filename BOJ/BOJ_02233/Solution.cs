namespace Algorithm.BOJ.BOJ_02233
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02233/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string bin = " " + Console.ReadLine()!;

            string[] input = Console.ReadLine()!.Split();
            int X = int.Parse(input[0]), Y = int.Parse(input[1]);
            if (X > Y)
                (X, Y) = (Y, X);

            Stack<int> stack = new();
            int depth = int.MaxValue;

            for (int j = 1; j <= N * 2; j++)
            {
                int i = 0;
                if (bin[j] == '0')
                    stack.Push(j);
                else
                    i = stack.Pop();

                if (j < X)
                {
                    continue;
                }
                else if (j < Y)
                {
                    depth = Math.Min(depth, stack.Count);
                }
                else
                {
                    if (stack.Count == depth - 1)
                    {
                        Console.WriteLine($"{i} {j}");
                        break;
                    }
                }
            }
        }
    }
}
