namespace Algorithm.BOJ.BOJ_18917
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_18917/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int M = ReadInt(sr);

            long sum = 0;
            int xor = 0;
            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < M; _++)
            {
                int q = ReadInt(sr);

                if (q == 1)
                {
                    int x = ReadInt(sr);
                    sum += x;
                    xor ^= x;
                }
                else if (q == 2)
                {
                    int x = ReadInt(sr);
                    sum -= x;
                    xor ^= x;
                }
                else if (q == 3)
                {
                    output.AppendLine(sum.ToString());
                }
                else if (q == 4)
                {
                    output.AppendLine(xor.ToString());
                }
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
