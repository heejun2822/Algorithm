namespace Algorithm.BOJ.BOJ_02872
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02872/input1.txt",
            "BOJ/BOJ_02872/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int consecutiveCnt = 0;
            int lastNumber = 0;

            for (int _ = 0; _ < N; _++)
            {
                int number = ReadInt(sr);

                if (number == lastNumber + 1)
                {
                    consecutiveCnt++;
                    lastNumber = number;
                }
                else if (number > lastNumber)
                {
                    consecutiveCnt = 1;
                    lastNumber = number;
                }

                if (number == N) break;
            }

            sw.WriteLine(N - consecutiveCnt);

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
