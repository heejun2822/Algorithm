namespace Algorithm.BOJ.BOJ_01463
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01463/input1.txt",
            "BOJ/BOJ_01463/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] memo = new int[N + 1];

            for (int i = 2; i <= N; i++)
            {
                memo[i] = memo[i - 1] + 1;
                if (i % 2 == 0) memo[i] = Math.Min(memo[i], memo[i / 2] + 1);
                if (i % 3 == 0) memo[i] = Math.Min(memo[i], memo[i / 3] + 1);
            }

            Console.WriteLine(memo[N]);
        }
    }
}
