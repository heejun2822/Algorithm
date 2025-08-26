namespace Algorithm.BOJ.BOJ_12711
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12711/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            for (int x = 1; x <= N; x++)
            {
                int P = ReadInt(sr), K = ReadInt(sr), L = ReadInt(sr);
                int[] frequencies = new int[L];

                for (int i = 0; i < L; i++)
                    frequencies[i] = ReadInt(sr);

                Array.Sort(frequencies, (a, b) => b - a);

                int minCnt = 0;

                for (int i = 0; i < L; i++)
                    minCnt += frequencies[i] * (1 + i / K);

                sw.WriteLine($"Case #{x}: {minCnt}");
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
