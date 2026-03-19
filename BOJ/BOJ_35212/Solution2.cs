namespace Algorithm.BOJ.BOJ_35212
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_35212/input1.txt",
            "BOJ/BOJ_35212/input2.txt",
            "BOJ/BOJ_35212/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr), w = ReadInt(sr);

            (int p, int t)[] mills = new (int, int)[n];

            for (int i = 0; i < n; i++)
                mills[i] = (ReadInt(sr), ReadInt(sr));

            double l = 0, r = 3e9;

            for (int _ = 0; _ < 60; _++)
            {
                double m = (l + r) / 2;

                double wheat = 0;

                foreach ((int p, int t) in mills)
                {
                    wheat += Math.Max(m - 2 * t, 0) * p;
                    if (wheat >= w) break;
                }

                if (wheat >= w)
                    r = m;
                else
                    l = m;
            }

            sw.WriteLine(r);

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
