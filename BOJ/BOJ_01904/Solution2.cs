namespace Algorithm.BOJ.BOJ_01904
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01904/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int[] memo = new int[N + 1];
            memo[0] = memo[1] = 1;
            for (int i = 2; i <= N; i++) memo[i] = (memo[i - 1] + memo[i - 2]) % 15746;

            Console.WriteLine(memo[N]);
        }
    }
}
