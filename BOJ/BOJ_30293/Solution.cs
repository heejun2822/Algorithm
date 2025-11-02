namespace Algorithm.BOJ.BOJ_30293
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30293/input1.txt",
            "BOJ/BOJ_30293/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] t = new int[N + 1];

            for (int i = 1; i <= N; i++)
                t[i] = ReadInt(sr);

            long[] p = new long[N + 1];
            long cnt = 0;

            for (int i = 1; i <= N; i++)
            {
                if (p[i] == t[i]) continue;

                long diff = t[i] - p[i];
                for (int j = i; j <= N; j += i)
                    p[j] += diff;
                cnt += Math.Abs(diff);
            }

            sw.WriteLine(cnt);

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
