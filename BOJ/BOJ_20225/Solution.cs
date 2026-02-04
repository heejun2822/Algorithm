namespace Algorithm.BOJ.BOJ_20225
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20225/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int m = ReadInt(sr), n = ReadInt(sr), p = ReadInt(sr);

                if (m == 0 && n == 0 && p == 0) break;

                bool[] infected = new bool[m + 1];
                infected[p] = true;

                for (int _ = 0; _ < n; _++)
                {
                    int a = ReadInt(sr), b = ReadInt(sr);
                    infected[a] = infected[b] = infected[a] || infected[b];
                }
                
                int cnt = 0;
                for (int i = 1; i <= m; i++)
                    if (infected[i])
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
