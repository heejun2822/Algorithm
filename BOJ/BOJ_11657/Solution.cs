namespace Algorithm.BOJ.BOJ_11657
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11657/input1.txt",
            "BOJ/BOJ_11657/input2.txt",
            "BOJ/BOJ_11657/input3.txt",
        ];

        private static readonly int INF = 5_000_000;

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            List<(int B, int C)>[] routeLists = new List<(int, int)>[N + 1];
            for (int _ = 0; _ < M; _++)
            {
                string[] abc = sr.ReadLine()!.Split();
                int A = int.Parse(abc[0]);
                int B = int.Parse(abc[1]);
                int C = int.Parse(abc[2]);
                (routeLists[A] ??= new()).Add((B, C));
            }

            if (BellmanFord(N, routeLists, out long[] minTime))
                for (int A = 2; A <= N; A++)
                    sw.WriteLine(minTime[A] == INF ? "-1" : minTime[A]);
            else
                sw.WriteLine("-1");

            sr.Close();
            sw.Close();
        }

        // 벨만 포드 (Bellman-Ford)
        private static bool BellmanFord(int N, List<(int B, int C)>[] routeLists, out long[] minTime)
        {
            minTime = new long[N + 1];
            Array.Fill(minTime, INF);
            minTime[1] = 0;

            for (int _ = 0; _ < N - 1; _++)
            {
                for (int A = 1; A <= N; A++)
                {
                    if (minTime[A] == INF) continue;
                    if (routeLists[A] == null) continue;

                    foreach ((int B, int C) in routeLists[A])
                        minTime[B] = Math.Min(minTime[B], minTime[A] + C);
                }
            }

            for (int A = 1; A <= N; A++)
            {
                if (minTime[A] == INF) continue;
                if (routeLists[A] == null) continue;

                foreach ((int B, int C) in routeLists[A])
                    if (minTime[A] + C < minTime[B]) return false; // 음수 사이클
            }

            return true;
        }
    }
}
