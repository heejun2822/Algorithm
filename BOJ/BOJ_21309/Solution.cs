namespace Algorithm.BOJ.BOJ_21309
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_21309/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int nrows = ReadInt(sr), mcolumns = ReadInt(sr);

            bool[,] grid = new bool[nrows, mcolumns];

            for (int i = 0; i < nrows; i++)
                for (int j = 0; j < mcolumns; j++)
                    grid[i, j] = ReadInt(sr) == 1;

            int cardinalCnt = 0;
            int intercardinalCnt = 0;

            for (int i = 0; i < nrows; i++)
            {
                for (int j = 0; j < mcolumns; j++)
                {
                    if (!grid[i, j]) continue;

                    if (j + 1 < mcolumns && grid[i, j + 1]) { cardinalCnt++; intercardinalCnt++; }
                    if (i + 1 < nrows && grid[i + 1, j]) { cardinalCnt++; intercardinalCnt++; }
                    if (i + 1 < nrows && j + 1 < mcolumns && grid[i + 1, j + 1]) intercardinalCnt++;
                    if (i + 1 < nrows && j - 1 >= 0 && grid[i + 1, j - 1]) intercardinalCnt++;
                }
            }

            sw.WriteLine($"{cardinalCnt} {intercardinalCnt}");

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
