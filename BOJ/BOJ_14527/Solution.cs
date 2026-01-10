namespace Algorithm.BOJ.BOJ_14527
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14527/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            (int cnt, int milk)[] cows = new (int, int)[N];

            for (int i = 0; i < N; i++)
            {
                int x = ReadInt(sr), y = ReadInt(sr);
                cows[i] = (x, y);
            }

            Array.Sort(cows, (a, b) => a.milk - b.milk);

            int minTime = 0;
            int l = 0, r = N - 1;

            while (l <= r)
            {
                minTime = Math.Max(minTime, cows[l].milk + cows[r].milk);

                int cnt = Math.Min(cows[l].cnt, cows[r].cnt);
                if ((cows[l].cnt -= cnt) == 0)
                    l++;
                if ((cows[r].cnt -= cnt) == 0)
                    r--;
            }

            sw.WriteLine(minTime);

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
