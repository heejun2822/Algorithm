namespace Algorithm.BOJ.BOJ_25682
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25682/input1.txt",
            "BOJ/BOJ_25682/input2.txt",
            "BOJ/BOJ_25682/input3.txt",
            "BOJ/BOJ_25682/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nmk = Console.ReadLine()!.Split();
            int N = int.Parse(nmk[0]);
            int M = int.Parse(nmk[1]);
            int K = int.Parse(nmk[2]);

            int[,] counts = new int[N + 1, M + 1];
            for (int i = 1; i <= N; i++)
            {
                string row = Console.ReadLine()!;
                for (int j = 1; j <= M; j++)
                {
                    bool currentColor = row[j - 1] == 'W';
                    bool rightColor = (i - j) % 2 == 0;
                    counts[i, j] = currentColor ^ rightColor ? 1 : 0;
                    counts[i, j] += counts[i - 1, j] + counts[i, j - 1] - counts[i - 1, j - 1];
                }
            }

            int min = N * M;
            for (int i = K; i <= N; i++)
            {
                for (int j = K; j <= M; j++)
                {
                    int cnt = counts[i, j] - counts[i, j - K] - counts[i - K, j] + counts[i - K, j - K];
                    min = Math.Min(min, Math.Min(cnt, K * K - cnt));
                }
            }

            Console.WriteLine(min);
        }
    }
}
