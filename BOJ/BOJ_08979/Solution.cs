namespace Algorithm.BOJ.BOJ_08979
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_08979/input1.txt",
            "BOJ/BOJ_08979/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), K = ReadInt(sr);

            int[,] medals = new int[N + 1, 3];

            for (int _ = 0; _ < N; _++)
            {
                int num = ReadInt(sr);
                for (int i = 0; i < 3; i++)
                    medals[num, i] = ReadInt(sr);
            }

            int rank = 1;

            for (int i = 1; i <= N; i++)
            {
                for (int m = 0; m < 3; m++)
                {
                    if (medals[i, m] > medals[K, m])
                    {
                        rank++;
                        break;
                    }
                    if (medals[i, m] < medals[K, m])
                    {
                        break;
                    }
                }
            }

            sw.WriteLine(rank);

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
