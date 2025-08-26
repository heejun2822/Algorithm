namespace Algorithm.BOJ.BOJ_17542
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17542/input1.txt",
            "BOJ/BOJ_17542/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int R = ReadInt(), C = ReadInt();

            int maxX = 0;
            int maxY = 0;

            for (int _ = 0; _ < R; _++)
            {
                int x = ReadInt();
                maxX = Math.Max(maxX, x);
            }

            for (int _ = 0; _ < C; _++)
            {
                int y = ReadInt();
                maxY = Math.Max(maxY, y);
                if (maxY > maxX) break;
            }

            Console.WriteLine(maxX == maxY ? "possible" : "impossible");
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
