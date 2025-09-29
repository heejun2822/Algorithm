namespace Algorithm.BOJ.BOJ_17123
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17123/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            System.Text.StringBuilder output = new();

            int T = ReadInt(sr);

            while (T-- > 0)
            {
                int N = ReadInt(sr), M = ReadInt(sr);

                int[] rowSum = new int[N];
                int[] colSum = new int[N];

                for (int r = 0; r < N; r++)
                {
                    for (int c = 0; c < N; c++)
                    {
                        int ele = ReadInt(sr);
                        rowSum[r] += ele;
                        colSum[c] += ele;
                    }
                }

                for (int _ = 0; _ < M; _++)
                {
                    int r1 = ReadInt(sr) - 1, c1 = ReadInt(sr) - 1;
                    int r2 = ReadInt(sr) - 1, c2 = ReadInt(sr) - 1;
                    int v = ReadInt(sr);
                    for (int r = r1; r <= r2; r++)
                        rowSum[r] += v * (c2 - c1 + 1);
                    for (int c = c1; c <= c2; c++)
                        colSum[c] += v * (r2 - r1 + 1);
                }

                output.AppendLine(string.Join(' ', rowSum));
                output.AppendLine(string.Join(' ', colSum));
            }

            sw.Write(output);

            sr.Close();
            sw.Close();
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
