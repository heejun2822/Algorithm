namespace Algorithm.BOJ.BOJ_06188
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06188/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), C = ReadInt(sr);

            int[,] connections = new int[N + 1, 2];

            for (int _ = 0; _ < C; _++)
            {
                int E = ReadInt(sr), B1 = ReadInt(sr), B2 = ReadInt(sr);
                connections[E, 0] = B1;
                connections[E, 1] = B2;
            }

            int[] distances = new int[N + 1];

            DFS(1, 1);

            System.Text.StringBuilder output = new();

            for (int i = 1; i <= N; i++)
                output.AppendLine(distances[i].ToString());

            sw.Write(output);

            sr.Close();
            sw.Close();

            void DFS(int pipe, int dist)
            {
                if (pipe == 0) return;

                distances[pipe] = dist;

                DFS(connections[pipe, 0], dist + 1);
                DFS(connections[pipe, 1], dist + 1);
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
