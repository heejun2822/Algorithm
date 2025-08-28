namespace Algorithm.BOJ.BOJ_02776
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02776/input.txt",
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
                HashSet<int> numbers = new(N);

                for (int _ = 0; _ < N; _++)
                    numbers.Add(ReadInt(sr));

                int M = ReadInt(sr);

                for (int _ = 0; _ < M; _++)
                    output.AppendLine(numbers.Contains(ReadInt(sr)) ? "1" : "0");
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
