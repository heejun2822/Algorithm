namespace Algorithm.BOJ.BOJ_32932
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_32932/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = ReadInt();
            int K = ReadInt();

            HashSet<int> obstacles = new(N);
            for (int i = 0; i < N; i++) obstacles.Add(CoordToId(ReadInt(), ReadInt()));

            int x = 0, y = 0;
            for (int _ = 0; _ < K; _++)
            {
                switch (Console.Read())
                {
                    case 'U': if (!obstacles.Contains(CoordToId(x, y + 1))) y++; break;
                    case 'D': if (!obstacles.Contains(CoordToId(x, y - 1))) y--; break;
                    case 'R': if (!obstacles.Contains(CoordToId(x + 1, y))) x++; break;
                    case 'L': if (!obstacles.Contains(CoordToId(x - 1, y))) x--; break;
                    default: break;
                }
            }

            Console.WriteLine($"{x} {y}");
        }

        private static int CoordToId(int x, int y)
        {
            return 1001 * x + y;
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
