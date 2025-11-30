namespace Algorithm.BOJ.BOJ_02118
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02118/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int[] accSum = new int[N + 1];

            for (int i = 1; i <= N; i++)
                accSum[i] = accSum[i - 1] + ReadInt(sr);

            int f = 1, b = 0;
            int maxDist = 0;

            while (f <= N)
            {
                int dist1 = accSum[f] - accSum[b];
                int dist2 = accSum[N] - dist1;

                if (dist1 < dist2)
                {
                    maxDist = Math.Max(maxDist, dist1);
                    f++;
                }
                else if (dist1 > dist2)
                {
                    maxDist = Math.Max(maxDist, dist2);
                    b++;
                }
                else
                {
                    maxDist = dist1;
                    break;
                }
            }

            sw.WriteLine(maxDist);

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
