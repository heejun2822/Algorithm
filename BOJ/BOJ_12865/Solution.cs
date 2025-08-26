namespace Algorithm.BOJ.BOJ_12865
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12865/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            (int W, int V)[] stuffs = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                string[] info = Console.ReadLine()!.Split();
                stuffs[i] = (int.Parse(info[0]), int.Parse(info[1]));
            }

            int[,] maxValues = new int[K + 1, N + 1];
            for (int i = 1; i <= K; i++)
                for (int j = 1; j <= N; j++)
                {
                    (int W, int V) = stuffs[j - 1];
                    maxValues[i, j] = W <= i
                        ? Math.Max(maxValues[i, j - 1], maxValues[i - W, j - 1] + V)
                        : maxValues[i, j - 1];
                }

            Console.WriteLine(maxValues[K, N]);
        }
    }
}
