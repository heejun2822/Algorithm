namespace Algorithm.BOJ.BOJ_32931
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_32931/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[,] cards = new int[2, N];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < N; j++)
                    cards[i, j] = ReadInt(sr);

            long[,] maxSum = new long[2, N];
            maxSum[0, 0] = cards[0, 0] + Math.Max(cards[1, 0], 0);
            maxSum[1, 0] = cards[0, 0] + cards[1, 0];

            for (int i = 1; i < N; i++)
            {
                maxSum[0, i] = Math.Max(
                    maxSum[0, i - 1] + cards[0, i] + Math.Max(cards[1, i], 0),
                    maxSum[1, i - 1] + cards[1, i] + cards[0, i]
                );
                maxSum[1, i] = Math.Max(
                    maxSum[1, i - 1] + cards[1, i] + Math.Max(cards[0, i], 0),
                    maxSum[0, i - 1] + cards[0, i] + cards[1, i]
                );
            }

            sw.WriteLine(maxSum[1, N - 1]);

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
