namespace Algorithm.BOJ.BOJ_25600
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25600/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = ReadInt();

            int maxScore = 0;

            for (int i = 0; i < N; i++)
            {
                int a = ReadInt(), d = ReadInt(), g = ReadInt();
                int score = a * (d + g);
                if (a == d + g) score *= 2;
                maxScore = Math.Max(maxScore, score);
            }

            Console.WriteLine(maxScore);
        }

        private static int ReadInt()
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = Console.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { Console.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
