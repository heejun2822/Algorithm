namespace Algorithm.BOJ.BOJ_11404
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11404/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            const int INF = 10_000_000;

            int n = int.Parse(sr.ReadLine()!);
            int m = int.Parse(sr.ReadLine()!);

            int[,] minCost = new int[n + 1, n + 1];
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    minCost[i, j] = i == j ? 0 : INF;

            for (int _ = 0; _ < m; _++)
            {
                string[] abc = sr.ReadLine()!.Split();
                int a = int.Parse(abc[0]);
                int b = int.Parse(abc[1]);
                int c = int.Parse(abc[2]);
                minCost[a, b] = Math.Min(minCost[a, b], c);
            }

            // 플로이드 워셜 (Floyd-Warshall)
            for (int k = 1; k <= n; k++)
                for (int i = 1; i <= n; i++)
                    for (int j = 1; j <= n; j++)
                        minCost[i, j] = Math.Min(minCost[i, j], minCost[i, k] + minCost[k, j]);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    sw.Write(minCost[i, j] == INF ? 0 : minCost[i, j]);
                    sw.Write(" ");
                }
                sw.Write("\n");
            }

            sr.Close();
            sw.Close();
        }
    }
}
