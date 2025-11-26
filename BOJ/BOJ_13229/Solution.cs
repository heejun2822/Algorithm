namespace Algorithm.BOJ.BOJ_13229
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13229/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr);
            int[] accSum = new int[n + 1];

            for (int i = 1; i <= n; i++)
                accSum[i] = accSum[i - 1] + ReadInt(sr);

            int m = ReadInt(sr);

            for (int _ = 0; _ < m; _++)
            {
                int start = ReadInt(sr), end = ReadInt(sr);

                sw.WriteLine(accSum[end + 1] - accSum[start]);
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
