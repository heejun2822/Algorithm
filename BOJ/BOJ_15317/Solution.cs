namespace Algorithm.BOJ.BOJ_15317
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15317/input1.txt",
            "BOJ/BOJ_15317/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr), X = ReadInt(sr);
            int[] C = new int[N];
            int[] S = new int[M];

            for (int i = 0; i < N; i++)
                C[i] = ReadInt(sr);
            for (int i = 0; i < M; i++)
                S[i] = ReadInt(sr);

            Array.Sort(C);
            Array.Sort(S);

            int l = 0, r = Math.Min(N, M);

            while (l < r)
            {
                int m = (l + r + 1) / 2;
                int sup = 0;

                for (int i = 0; i < m; i++)
                    if (C[i] > S[M - m + i] && (sup += C[i] - S[M - m + i]) > X)
                        break;

                if (sup <= X)
                    l = m;
                else
                    r = m - 1;
            }

            sw.WriteLine(l);

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
