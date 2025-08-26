namespace Algorithm.BOJ.BOJ_01956
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01956/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            const int INF = 8_000_000;

            string[] ve = sr.ReadLine()!.Split();
            int V = int.Parse(ve[0]);
            int E = int.Parse(ve[1]);

            int[,] minPath = new int[V, V];
            for (int a = 0; a < V; a++)
                for (int b = 0; b < V; b++)
                    minPath[a, b] = INF;

            for (int _ = 0; _ < E; _++)
            {
                string[] abc = sr.ReadLine()!.Split();
                int a = int.Parse(abc[0]);
                int b = int.Parse(abc[1]);
                int c = int.Parse(abc[2]);
                minPath[a - 1, b - 1] = c;
            }

            for (int i = 0; i < V; i++)
                for (int a = 0; a < V; a++)
                {
                    if (minPath[a, i] == INF) continue;
                    for (int b = 0; b < V; b++)
                        minPath[a, b] = Math.Min(minPath[a, b], minPath[a, i] + minPath[i, b]);
                }

            int minCycle = INF;
            for (int i = 0; i < V; i++)
                minCycle = Math.Min(minCycle, minPath[i, i]);

            sw.WriteLine(minCycle == INF ? "-1" : minCycle);

            sr.Close();
            sw.Close();
        }
    }
}
