namespace Algorithm.BOJ.BOJ_30559
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30559/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr), m = ReadInt(sr), k = ReadInt(sr);

            int[] piers = new int[m + 1];
            int[] charges = new int[m + 1];

            for (int _ = 0; _ < k; _++)
            {
                int p = ReadInt(sr), c = ReadInt(sr);

                if (piers[c] == 0)
                {
                    piers[c] = p;
                }
                else if (piers[c] == p)
                {
                    charges[c] += 100;
                    piers[c] = 0;
                }
                else
                {
                    charges[c] += Math.Abs(piers[c] - p);
                    piers[c] = 0;
                }
            }

            System.Text.StringBuilder output = new();

            for (int i = 1; i <= m; i++)
            {
                if (piers[i] != 0)
                    charges[i] += 100;
                output.Append(charges[i]).Append(' ');
            }

            sw.WriteLine(output);

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
