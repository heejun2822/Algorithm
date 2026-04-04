namespace Algorithm.BOJ.BOJ_14890
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14890/input1.txt",
            "BOJ/BOJ_14890/input2.txt",
            "BOJ/BOJ_14890/input3.txt",
            "BOJ/BOJ_14890/input4.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), L = ReadInt(sr);
            int[,] map = new int[N, N];

            for (int r = 0; r < N; r++)
                for (int c = 0; c < N; c++)
                    map[r, c] = ReadInt(sr);

            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                if (CheckPathRow(i))
                    cnt++;
                if (CheckPathCol(i))
                    cnt++;
            }

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();

            bool CheckPathRow(int r)
            {
                int flatCnt = 1;
                for (int c = 1; c < N; c++)
                    if (!CheckSlope(map[r, c], map[r, c - 1], ref flatCnt))
                        return false;
                return flatCnt >= 0;
            }

            bool CheckPathCol(int c)
            {
                int flatCnt = 1;
                for (int r = 1; r < N; r++)
                    if (!CheckSlope(map[r, c], map[r - 1, c], ref flatCnt))
                        return false;
                return flatCnt >= 0;
            }

            bool CheckSlope(int currH, int prevH, ref int flatCnt)
            {
                switch (currH - prevH)
                {
                    case 0:
                        flatCnt++;
                        return true;
                    case 1:
                        if (flatCnt >= L)
                        {
                            flatCnt = 1;
                            return true;
                        }
                        return false;
                    case -1:
                        if (flatCnt >= 0)
                        {
                            flatCnt = 1 - L;
                            return true;
                        }
                        return false;
                    default:
                        return false;
                }
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
