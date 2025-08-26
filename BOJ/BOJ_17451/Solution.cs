namespace Algorithm.BOJ.BOJ_17451
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17451/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr);

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
                v[i] = ReadInt(sr);

            long earthV = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (v[i] > earthV)
                    earthV = v[i];
                else if (earthV % v[i] != 0)
                    earthV = v[i] * (earthV / v[i] + 1);
            }

            sw.WriteLine(earthV);

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
