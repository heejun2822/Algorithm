namespace Algorithm.BOJ.BOJ_17048
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17048/input1.txt",
            "BOJ/BOJ_17048/input2.txt",
            "BOJ/BOJ_17048/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] frequencies = new int[N];

            for (int i = 0; i < N; i++)
                frequencies[i] = ReadInt(sr);

            Dictionary<int, int> count = new();
            int maxCnt = 0;

            for (int i = 0; i < N; i++)
            {
                int X = ReadInt(sr) - frequencies[i];
                if (!count.TryAdd(X, 1)) count[X]++;
                maxCnt = Math.Max(maxCnt, count[X]);
            }

            sw.WriteLine(maxCnt);

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
