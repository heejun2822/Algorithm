namespace Algorithm.BOJ.BOJ_32884
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32884/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);

            int[,] accSum = new int[N + 1, M + 1];

            for (int r = 1; r <= N; r++)
                for (int c = 1; c <= M; c++)
                    accSum[r, c] = accSum[r - 1, c] + ReadInt(sr);

            int maxSum = 0;

            for (int r1 = 1; r1 <= N; r1++)
            {
                for (int r2 = r1; r2 <= N; r2++)
                {
                    int localMaxSum = 0;
                    for (int c = 1; c <= M; c++)
                    {
                        localMaxSum = Math.Max(localMaxSum, 0);
                        localMaxSum += accSum[r2, c] - accSum[r1 - 1, c];
                        maxSum = Math.Max(maxSum, localMaxSum);
                    }
                }
            }

            sw.WriteLine(maxSum);

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
