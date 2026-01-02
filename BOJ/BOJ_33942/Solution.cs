namespace Algorithm.BOJ.BOJ_33942
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33942/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            System.Text.StringBuilder output = new();

            int T = (int)ReadLong(sr);

            while (T-- > 0)
            {
                long N = ReadLong(sr);

                long cntM = (N + 2) / 3;
                long l = 1, r = int.MaxValue;

                while (l < r)
                {
                    long m = (l + r) / 2;
                    long q = m / 3;

                    if (q * (q + 1) / 2 * 3 + (q + 1) * (m % 3) > cntM)
                        r = m;
                    else
                        l = m + 1;
                }

                output.AppendLine(r.ToString());
            }

            sw.Write(output);

            sr.Close();
            sw.Close();
        }

        private static long ReadLong(StreamReader sr)
        {
            long c, val = 0, sign = 1;
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
