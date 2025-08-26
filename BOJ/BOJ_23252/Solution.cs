namespace Algorithm.BOJ.BOJ_23252
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23252/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < T; _++)
            {
                int A = ReadInt(sr), B = ReadInt(sr), C = ReadInt(sr);

                bool answer = C > 0
                    ? A >= C && (A - C) % 2 == 0
                    : A % 2 == 0 && (B % 2 == 0 || (B % 2 == 1 && A >= 2));

                output.AppendLine(answer ? "Yes" : "No");
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
