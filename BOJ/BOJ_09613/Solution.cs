namespace Algorithm.BOJ.BOJ_09613
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09613/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int t = ReadInt(sr);

            System.Text.StringBuilder answer = new();

            for (int _ = 0; _ < t; _++)
            {
                int n = ReadInt(sr);

                int[] numbers = new int[n];
                long gcdSum = 0;

                for (int i = 0; i < n; i++)
                {
                    numbers[i] = ReadInt(sr);

                    for (int j = 0; j < i; j++)
                        gcdSum += GCD(numbers[i], numbers[j]);
                }

                answer.AppendLine(gcdSum.ToString());
            }

            sw.Write(answer);

            sr.Close();
            sw.Close();

            int GCD(int a, int b)
            {
                return b == 0 ? a : GCD(b, a % b);
            }
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
