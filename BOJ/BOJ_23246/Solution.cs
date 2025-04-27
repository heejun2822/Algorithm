namespace Algorithm.BOJ.BOJ_23246
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_23246/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = ReadInt();

            (int mul, int sum, int num)[] scores = new (int, int, int)[n];

            for (int i = 0; i < n; i++)
            {
                int b = ReadInt(), p = ReadInt(), q = ReadInt(), r = ReadInt();
                scores[i] = (p * q * r, p + q + r, b);
            }

            Array.Sort(scores);

            Console.WriteLine($"{scores[0].num} {scores[1].num} {scores[2].num}");
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
