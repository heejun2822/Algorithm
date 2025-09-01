namespace Algorithm.BOJ.BOJ_33062
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33062/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            System.Text.StringBuilder output = new();

            while (T-- > 0)
            {
                int N = ReadInt(sr);

                int cnt = 0;
                long l = 45, h = 49;

                while (N >= l)
                {
                    cnt += (int)(Math.Min(N, h) - l + 1);
                    l = l * 10 - 5;
                    h = h * 10 + 9;
                }

                output.AppendLine(cnt.ToString());
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
