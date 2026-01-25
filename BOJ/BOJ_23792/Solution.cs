namespace Algorithm.BOJ.BOJ_23792
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23792/input.txt",
        ];

        // 시간 초과
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

            int min = Math.Min(Math.Min(A[1], B[1]), C[1]);
            int max = Math.Max(Math.Max(A[N], B[N]), C[N]);

            int Q = ReadInt(sr);

            while (Q-- > 0)
            {
                int x = ReadInt(sr), y = ReadInt(sr), z = ReadInt(sr), k = ReadInt(sr);

                int l = min, r = max;

                while (l <= r)
                {
                    int m = (l + r) / 2;

                    int type = 0;
                    int idx = 0;
                    int totalCnt = 0;

                    var res = Search(A, x, m);
                    totalCnt += res.cnt;
                    if (res.contained)
                        (type, idx) = (1, res.cnt);

                    res = Search(B, y, m);
                    totalCnt += res.cnt;
                    if (res.contained)
                        (type, idx) = (2, res.cnt);

                    res = Search(C, z, m);
                    totalCnt += res.cnt;
                    if (res.contained)
                        (type, idx) = (3, res.cnt);

                    if (type != 0 && totalCnt == k)
                    {
                        sw.WriteLine($"{type} {idx}");
                        break;
                    }
                    if (totalCnt < k)
                        l = m + 1;
                    else
                        r = m - 1;
                }
            }

            sr.Close();
            sw.Close();

            (bool contained, int cnt) Search(int[] arr, int lim, int num)
            {
                int l = 0, r = lim;

                while (l < r)
                {
                    int m = (l + r + 1) / 2;

                    if (arr[m] < num)
                        l = m;
                    else if (arr[m] > num)
                        r = m - 1;
                    else
                        return (true, m);
                }

                return (false, l);
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
