namespace Algorithm.BOJ.BOJ_14827
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14827/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            (int E, int L, int D)[] tours;
            bool[] visited;

            int T = ReadInt(sr);

            for (int x = 1; x <= T; x++)
            {
                int C = ReadInt(sr);

                tours = new (int, int, int)[2 * C];
                visited = new bool[2 * C];

                for (int i = 0; i < 2 * C; i++)
                {
                    int E = ReadInt(sr), L = ReadInt(sr), D = ReadInt(sr);
                    tours[i] = (E, L, D);
                }

                int y = int.MaxValue;
                DFS(2 * C, 1, 0, 0, ref y);

                sw.WriteLine($"Case #{x}: {y}");
            }

            sr.Close();
            sw.Close();

            void DFS(int idx, int camp, int hour, int time, ref int minTime)
            {
                if (time >= minTime)
                    return;

                if (idx == 0)
                {
                    minTime = Math.Min(minTime, time);
                    return;
                }

                for (int i = 0; i < 2; i++)
                {
                    int tourIdx = (camp - 1) * 2 + i;

                    if (visited[tourIdx]) continue;

                    visited[tourIdx] = true;
                    (int E, int L, int D) = tours[tourIdx];
                    DFS(idx - 1, E, (L + D) % 24, time + (L - hour + 24) % 24 + D, ref minTime);
                    visited[tourIdx] = false;
                }
            }
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
