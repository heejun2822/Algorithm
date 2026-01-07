namespace Algorithm.BOJ.BOJ_33991
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33991/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int X1 = ReadInt(sr), Y1 = ReadInt(sr), X2 = ReadInt(sr), Y2 = ReadInt(sr), X3 = ReadInt(sr), Y3 = ReadInt(sr);
            int Q = ReadInt(sr);

            while (Q-- > 0)
            {
                int X = ReadInt(sr), Y = ReadInt(sr), T1 = ReadInt(sr), T2 = ReadInt(sr), T3 = ReadInt(sr);

                int minTime = int.MaxValue;
                minTime = Math.Min(minTime, (Math.Abs(X - X1) + Math.Abs(Y - Y1) + T1 - 1) / T1 * T1);
                minTime = Math.Min(minTime, (Math.Abs(X - X2) + Math.Abs(Y - Y2) + T2 - 1) / T2 * T2);
                minTime = Math.Min(minTime, (Math.Abs(X - X3) + Math.Abs(Y - Y3) + T3 - 1) / T3 * T3);

                sw.WriteLine(minTime);
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
