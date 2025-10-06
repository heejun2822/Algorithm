namespace Algorithm.BOJ.BOJ_15805
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15805/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int[] parents = new int[(N + 1) / 2];
            Array.Fill(parents, -2);

            int prevA = -1;
            for (int _ = 0; _ < N; _++)
            {
                int A = ReadInt(sr);
                if (parents[A] == -2)
                    parents[A] = prevA;
                prevA = A;
            }

            sw.WriteLine(parents.Length);
            sw.WriteLine(string.Join(' ', parents));

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
