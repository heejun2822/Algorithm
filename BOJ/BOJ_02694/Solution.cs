namespace Algorithm.BOJ.BOJ_02694
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02694/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            while (T-- > 0)
            {
                int M = ReadInt(sr);

                int[] accSum = new int[M + 1];
                int maxNum = 0;

                for (int i = 1; i <= M; i++)
                {
                    int num = ReadInt(sr);
                    accSum[i] = accSum[i - 1] + num;
                    maxNum = Math.Max(maxNum, num);
                }

                for (int i = 1; i <= M; i++)
                {
                    int sum = accSum[i];

                    if (accSum[M] % sum != 0 || sum < maxNum) continue;

                    int s = i, e = i + 1;
                    bool success = true;

                    while (e <= M)
                    {
                        success = false;
                        int nextSum = accSum[e] - accSum[s];

                        if (nextSum > sum) break;

                        if (nextSum == sum)
                        {
                            success = true;
                            s = e;
                        }
                        e++;
                    }

                    if (success)
                    {
                        sw.WriteLine(sum);
                        break;
                    }
                }
            }

            sr.Close();
            sw.Close();
        }

        // Upgraded ReadInt
        private static int ReadInt(StreamReader sr)
        {
            bool isValid = false;
            int c, value = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) { if (isValid) break; else continue; }
                if (c == '\r') { sr.Read(); if (isValid) break; else continue; }
                if (c == '-') { sign = -1; continue; }
                value = value * 10 + c - '0';
                isValid = true;
            }
            return value * sign;
        }
    }
}
