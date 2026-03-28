namespace Algorithm.BOJ.BOJ_25252
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25252/input1.txt",
            "BOJ/BOJ_25252/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr), s1 = ReadInt(sr), s2 = ReadInt(sr);

            int[] crates = new int[n + 1];
            int targetIdx = 0;

            for (int i = 0; i < s1; i++)
                if ((crates[i] = ReadInt(sr)) == 0)
                    targetIdx = i;
            for (int i = 0; i < s2; i++)
                if ((crates[n - i] = ReadInt(sr)) == 0)
                    targetIdx = n - i;

            int cnt = 0;

            int max = 0;
            for (int i = targetIdx - 1; i >= 0; i--)
            {
                if (crates[i] > max)
                {
                    cnt++;
                    max = crates[i];
                }
            }
            max = 0;
            for (int i = targetIdx + 1; i <= n; i++)
            {
                if (crates[i] > max)
                {
                    cnt++;
                    max = crates[i];
                }
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
