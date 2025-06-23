namespace Algorithm.BOJ.BOJ_13217
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
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

            int[] amountCnt = new int[M + 1];

            for (int i = 0; i < N; i++)
            {
                int m_i = ReadInt(sr);

                amountCnt[m_i % M]++;
                if ((amountCnt[M] += m_i / M) >= K) break;
            }

            long maxAmount = 0;
            int leftCnt = K;

            for (long a = M; a > 0; a--)
            {
                if (amountCnt[a] == 0) continue;

                if (leftCnt > amountCnt[a])
                {
                    maxAmount += a * amountCnt[a];
                    leftCnt -= amountCnt[a];
                }
                else
                {
                    maxAmount += a * leftCnt;
                    leftCnt = 0;
                    break;
                }
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
