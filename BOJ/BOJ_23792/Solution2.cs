namespace Algorithm.BOJ.BOJ_23792
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23792/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] A = new int[N + 1];
            int[] B = new int[N + 1];
            int[] C = new int[N + 1];

            for (int i = 1; i <= N; i++)
                A[i] = ReadInt(sr);
            for (int i = 1; i <= N; i++)
                B[i] = ReadInt(sr);
            for (int i = 1; i <= N; i++)
                C[i] = ReadInt(sr);

            int Q = ReadInt(sr);

            while (Q-- > 0)
            {
                int x = ReadInt(sr), y = ReadInt(sr), z = ReadInt(sr), k = ReadInt(sr);

                int type = 1;
                int idx = TrySearch(A, x, B, y, C, z, k);
                if (idx == -1)
                {
                    type = 2;
                    idx = TrySearch(B, y, A, x, C, z, k);
                }
                if (idx == -1)
                {
                    type = 3;
                    idx = TrySearch(C, z, A, x, B, y, k);
                }

                sw.WriteLine($"{type} {idx}");
            }

            sr.Close();
            sw.Close();

            int TrySearch(int[] targetArr, int tLim, int[] restArr1, int rLim1, int[] restArr2, int rLim2, int k)
            {
                int l = 1, r = tLim;

                while (l <= r)
                {
                    int m = (l + r) / 2;

                    int cnt = m + FindIndex(restArr1, rLim1, targetArr[m]) + FindIndex(restArr2, rLim2, targetArr[m]);

                    if (cnt < k)
                        l = m + 1;
                    else if (cnt > k)
                        r = m - 1;
                    else
                        return m;
                }

                return -1;
            }

            int FindIndex(int[] arr, int lim, int num)
            {
                int l = 0, r = lim;

                while (l < r)
                {
                    int m = (l + r + 1) / 2;

                    if (arr[m] < num)
                        l = m;
                    else
                        r = m - 1;
                }

                return l;
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
