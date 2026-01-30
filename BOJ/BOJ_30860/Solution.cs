namespace Algorithm.BOJ.BOJ_30860
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30860/input1.txt",
            "BOJ/BOJ_30860/input2.txt",
            "BOJ/BOJ_30860/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr);

            int cnt = 1;
            int c = 0;

            for (int _ = 0; _ < n; _++)
            {
                int l = ReadInt(sr), m = ReadInt(sr);

                if (c > m)
                {
                    cnt++;
                    c = 0;
                }

                c = Math.Clamp(c, l, m);
            }

            sw.WriteLine(cnt);

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
