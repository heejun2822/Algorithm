namespace Algorithm.BOJ.BOJ_18546
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_18546/input.txt",
        ];

        public static void Run(string[] args)
        {
            int mod = (int)1e9 + 7;
            int n = ReadInt();
            int a1 = ReadInt(), a2 = ReadInt();

            Console.WriteLine((a1 - a2 + mod) % mod);
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
