namespace Algorithm.BOJ.BOJ_32205
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32205/input1.txt",
            "BOJ/BOJ_32205/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            System.Collections.BitArray exists = new(1_000_001);
            bool success = false;

            while (!success && N-- > 0)
            {
                for (int _ = 0; _ < 3; _++)
                {
                    int l = ReadInt(sr);
                    success |= exists[l];
                    exists[l] = true;
                }
            }

            sw.WriteLine(success ? 1 : 0);

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
