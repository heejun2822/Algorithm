namespace Algorithm.BOJ.BOJ_13217
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13217/input1.txt",
            "BOJ/BOJ_13217/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr), K = ReadInt(sr);

            long maxAmount = 0;
            int leftCnt = K;
            List<int> amounts = new(N);

            for (int i = 0; i < N; i++)
            {
                int m_i = ReadInt(sr);

                int cnt = Math.Min(m_i / M, leftCnt);
                maxAmount += M * cnt;
                if ((leftCnt -= cnt) == 0) break;
                if ((m_i %= M) > 0) amounts.Add(m_i);
            }

            if (leftCnt > 0)
            {
                amounts.Sort((a, b) => b - a);

                int cnt = Math.Min(leftCnt, amounts.Count);
                for (int i = 0; i < cnt; i++)
                    maxAmount += amounts[i];
            }

            sw.WriteLine(maxAmount);

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
