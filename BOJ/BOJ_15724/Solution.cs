namespace Algorithm.BOJ.BOJ_15724
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15724/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);
            int[,] accSum = new int[N + 1, M + 1];

            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= M; j++)
                    accSum[i, j] = accSum[i - 1, j] + accSum[i, j - 1] - accSum[i - 1, j - 1] + ReadInt(sr);

            int K = ReadInt(sr);

            for (int _ = 0; _ < K; _++)
            {
                int x1 = ReadInt(sr) - 1, y1 = ReadInt(sr) - 1, x2 = ReadInt(sr), y2 = ReadInt(sr);
                sw.WriteLine(accSum[x2, y2] - accSum[x1, y2] - accSum[x2, y1] + accSum[x1, y1]);
            }

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
