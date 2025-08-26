namespace Algorithm.BOJ.BOJ_17206
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17206/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < T; _++)
            {
                int N = ReadInt(sr);

                int sum = 0;

                int cnt = N / 3;
                sum += cnt * (cnt + 1) / 2 * 3;

                cnt = N / 7;
                sum += cnt * (cnt + 1) / 2 * 7;

                cnt = N / 21;
                sum -= cnt * (cnt + 1) / 2 * 21;

                output.AppendLine(sum.ToString());
            }

            sw.Write(output);

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
