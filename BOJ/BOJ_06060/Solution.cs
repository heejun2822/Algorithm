namespace Algorithm.BOJ.BOJ_06060
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06060/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = ReadInt();

            bool isClockwise = true;

            for (int _ = 0; _ < N - 1; _++)
            {
                int S = ReadInt(), D = ReadInt(), C = ReadInt();
                if (C == 1) isClockwise = !isClockwise;
            }

            Console.WriteLine(isClockwise ? "0" : "1");
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
