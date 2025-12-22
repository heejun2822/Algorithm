namespace Algorithm.BOJ.BOJ_28129
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28129/input1.txt",
            "BOJ/BOJ_28129/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int mod = 1_000_000_007;

            int N = ReadInt(sr), K = ReadInt(sr);

            int[][] accSum = new int[N + 1][];

            int a = ReadInt(sr), b = ReadInt(sr);

            accSum[1] = new int[b + 1];

            for (int D = a; D <= b; D++)
                accSum[1][D] = accSum[1][D - 1] + 1;

            for (int i = 2; i <= N; i++)
            {
                a = ReadInt(sr);
                b = ReadInt(sr);

                accSum[i] = new int[b + 1];

                for (int D = a; D <= b; D++)
                {
                    int r = Math.Clamp(D + K, 1, accSum[i - 1].Length - 1);
                    int l = Math.Clamp(D - K, 1, accSum[i - 1].Length - 1);
                    accSum[i][D] = ((accSum[i][D - 1] + (accSum[i - 1][r] - accSum[i - 1][l - 1])) % mod + mod) % mod;
                }
            }

            sw.WriteLine(accSum[N][b]);

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
