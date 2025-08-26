namespace Algorithm.BOJ.BOJ_11544
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11544/input1.txt",
            "BOJ/BOJ_11544/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int[] cards = { 1, 10, 100, 1000, 10000 };

            int N = ReadInt(sr), M = ReadInt(sr);

            int extraPoints = 0;

            for (int _ = 0; _ < M; _++)
            {
                int B = ReadInt(sr);
                int C1 = ReadInt(sr);
                int sumC = 0;

                for (int i = 1; i < N; i++)
                    sumC += ReadInt(sr);

                int point = 0;
                int maxPoint = 0;

                foreach (int c in cards)
                {
                    if (sumC + c > B) break;

                    maxPoint = c;
                    if (c == C1) point = c;
                }

                extraPoints += maxPoint - point;
            }

            sw.WriteLine(extraPoints);

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
