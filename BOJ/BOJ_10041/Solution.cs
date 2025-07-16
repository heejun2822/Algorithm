namespace Algorithm.BOJ.BOJ_10041
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10041/input.txt",
        ];

        public static void Run(string[] args)
        {
            int W = ReadInt(), H = ReadInt(), N = ReadInt();

            int X = ReadInt(), Y = ReadInt();
            int cnt = 0;

            for (int _ = 0; _ < N - 1; _++)
            {
                int nextX = ReadInt(), nextY = ReadInt();

                int dx = nextX - X, dy = nextY - Y;
                cnt += dx * dy >= 0 ? Math.Max(Math.Abs(dx), Math.Abs(dy)) : Math.Abs(dx) + Math.Abs(dy);

                X = nextX;
                Y = nextY;
            }

            Console.WriteLine(cnt);
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
