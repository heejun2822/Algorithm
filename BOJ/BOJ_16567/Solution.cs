namespace Algorithm.BOJ.BOJ_16567
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16567/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);
            bool[] binaryRoad = new bool[N + 2];

            int flipCnt = 0;
            int i;

            for (i = 1; i <= N; i++)
            {
                binaryRoad[i] = ReadInt(sr) == 1;
                if (binaryRoad[i] && !binaryRoad[i - 1]) flipCnt++;
            }

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < M; _++)
            {
                if (ReadInt(sr) == 0)
                {
                    output.AppendLine(flipCnt.ToString());
                }
                else if (!binaryRoad[i = ReadInt(sr)])
                {
                    binaryRoad[i] = true;
                    int adjacentCnt = (binaryRoad[i - 1] ? 1 : 0) + (binaryRoad[i + 1] ? 1 : 0);
                    flipCnt += 1 - adjacentCnt;
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
