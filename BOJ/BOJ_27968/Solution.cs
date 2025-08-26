namespace Algorithm.BOJ.BOJ_27968
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27968/input1.txt",
            "BOJ/BOJ_27968/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = (int)ReadLong(sr), M = (int)ReadLong(sr);

            long[] accA = new long[M + 1];

            for (int i = 1; i <= M; i++)
                accA[i] = accA[i - 1] + ReadLong(sr);

            System.Text.StringBuilder answer = new();

            for (int _ = 0; _ < N; _++)
            {
                long B = ReadLong(sr);

                if (B > accA[M])
                {
                    answer.AppendLine("Go away!");
                    continue;
                }

                int low = 1, high = M;

                while (low < high)
                {
                    int mid = (low + high) / 2;

                    if (B < accA[mid])
                        high = mid;
                    else if (B > accA[mid])
                        low = mid + 1;
                    else
                        low = high = mid;
                }

                answer.AppendLine(low.ToString());
            }

            sw.Write(answer);

            sr.Close();
            sw.Close();
        }

        private static long ReadLong(StreamReader sr)
        {
            long c, val = 0, sign = 1;
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
