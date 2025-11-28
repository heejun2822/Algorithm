namespace Algorithm.BOJ.BOJ_31673
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31673/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);
            int[] V = new int[N];

            long totalV = 0;

            for (int i = 0; i < N; i++)
                totalV += V[i] = ReadInt(sr);

            Array.Sort(V, (a, b) => b - a);

            long halfV = (totalV + 1) / 2;
            long acquiredV = 0;

            for (int i = 0; i < N; i++)
            {
                if ((acquiredV += V[i]) >= halfV)
                {
                    sw.WriteLine(M / (i + 2));
                    break;
                }
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
