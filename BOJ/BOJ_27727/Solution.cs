namespace Algorithm.BOJ.BOJ_27727
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27727/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            List<(int idx, int num)> list = new();
            long btnCnt = 0;

            for (int idx = 1; idx <= N; idx++)
            {
                int num = ReadInt(sr);

                if (list.Count == 0 || num > list[^1].num)
                {
                    list.Add((idx, num));
                }
                else if (num == list[^1].num)
                {
                    list[^1] = (idx, num);
                }
                else if (num < list[^1].num)
                {
                    int maxNum = list[^1].num;
                    int prevIdx = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        btnCnt += (long)(maxNum - list[i].num) * (list[i].idx - prevIdx);
                        prevIdx = list[i].idx;
                    }
                    btnCnt += maxNum - num;
                    list.Clear();
                    list.Add((idx, maxNum));
                }
            }

            long K = long.Parse(sr.ReadLine()!) - btnCnt;
            long sortedCnt = (btnCnt > 0 && K >= 0) ? 1 : 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (K < list[i].idx) break;

                long cnt = K / list[i].idx;
                if (i + 1 < list.Count)
                    cnt = Math.Min(cnt, list[i + 1].num - list[i].num);

                sortedCnt += cnt;
                K -= list[i].idx * cnt;
            }

            sw.WriteLine(sortedCnt);

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
