namespace Algorithm.BOJ.BOJ_34116
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_34116/input1.txt",
            "BOJ/BOJ_34116/input2.txt",
            "BOJ/BOJ_34116/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int minY = 100_000_000;
            int maxY = -100_000_000;
            int upperMinX = 100_000_000;
            int upperMaxX = -100_000_000;
            int lowerMinX = 100_000_000;
            int lowerMaxX = -100_000_000;

            for (int _ = 0; _ < N; _++)
            {
                int x = ReadInt(sr), y = ReadInt(sr);

                minY = Math.Min(minY, y);
                maxY = Math.Max(maxY, y);
                upperMinX = Math.Min(upperMinX, x + y);
                upperMaxX = Math.Max(upperMaxX, x - y);
                lowerMinX = Math.Min(lowerMinX, x - y);
                lowerMaxX = Math.Max(lowerMaxX, x + y);
            }

            sw.WriteLine(Math.Min(upperMaxX - upperMinX + 2 * maxY, lowerMaxX - lowerMinX - 2 * minY));

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
