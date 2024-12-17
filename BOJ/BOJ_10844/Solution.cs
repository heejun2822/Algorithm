namespace Algorithm.BOJ.BOJ_10844
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10844/input1.txt",
            "BOJ/BOJ_10844/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[,] memo = new int[N, 10];
            for (int d = 1; d < 10; d++) memo[0, d] = 1;

            for (int i = 1; i < N; i++)
            for (int d = 0; d < 10; d++)
            {
                if (d == 0) memo[i, d] = memo[i - 1, 1];
                else if (d == 9) memo[i, d] = memo[i - 1, 8];
                else memo[i, d] = (memo[i - 1, d - 1] + memo[i - 1, d + 1]) % (int)1e9;
            }

            int ans = 0;
            for (int d = 0; d < 10; d++) ans = (ans + memo[N - 1, d]) % (int)1e9;

            Console.WriteLine(ans);
        }
    }
}
