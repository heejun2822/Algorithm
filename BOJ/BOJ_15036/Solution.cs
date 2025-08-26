namespace Algorithm.BOJ.BOJ_15036
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15036/input1.txt",
            "BOJ/BOJ_15036/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = ReadInt();

            double length = 0;

            for (int _ = 0; _ < N; _++)
            {
                int code = ReadInt();
                length += code == 0 ? 2 : 1d / code;
            }

            Console.WriteLine(length);
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
