namespace Algorithm.BOJ.BOJ_15781
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15781/input1.txt",
            "BOJ/BOJ_15781/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = ReadInt(), M = ReadInt();

            int maxH = 0, maxA = 0;
            for (int _ = 0; _ < N; _++) maxH = Math.Max(maxH, ReadInt());
            for (int _ = 0; _ < M; _++) maxA = Math.Max(maxA, ReadInt());

            Console.WriteLine(maxH + maxA);
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
