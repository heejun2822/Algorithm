namespace Algorithm.BOJ.BOJ_30962
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30962/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            const int LIM = 100_000;

            List<(int x, int y)>[] pointLists = new List<(int, int)>[LIM + 1];

            for (int d = 1; d <= LIM; d++)
                pointLists[d] = new();

            int x = 1;
            while (x * x < LIM)
            {
                int y = 1;
                int sqrD;
                while ((sqrD = x * x + y * y) <= LIM)
                {
                    pointLists[sqrD].Add((x, y));
                    y++;
                }
                x++;
            }

            int Q = ReadInt(sr);

            while (Q-- > 0)
            {
                int x1 = ReadInt(sr), y1 = ReadInt(sr), x2 = ReadInt(sr), y2 = ReadInt(sr), w = ReadInt(sr);

                int cnt = 0;

                foreach ((int px, int py) in pointLists[w])
                    if (px * y1 - py * x1 >= 0 && px * y2 - py * x2 <= 0)
                        cnt++;

                sw.WriteLine(cnt);
            }

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
