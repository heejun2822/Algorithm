namespace Algorithm.BOJ.BOJ_18126
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_18126/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            List<(int r, int len)>[] pathLists = new List<(int, int)>[N + 1];

            for (int i = 1; i <= N; i++) pathLists[i] = new();
            for (int _ = 0; _ < N - 1; _++)
            {
                int A = ReadInt(sr), B = ReadInt(sr), C = ReadInt(sr);
                pathLists[A].Add((B, C));
                pathLists[B].Add((A, C));
            }

            bool[] visited = new bool[N + 1];
            long maxDistance = 0;

            DFS(1, 0);

            sw.WriteLine(maxDistance);

            sr.Close();
            sw.Close();

            void DFS(int room, long distance)
            {
                visited[room] = true;
                maxDistance = Math.Max(maxDistance, distance);

                foreach ((int r, int len) in pathLists[room])
                    if (!visited[r])
                        DFS(r, distance + len);
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
