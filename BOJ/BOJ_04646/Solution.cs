namespace Algorithm.BOJ.BOJ_04646
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04646/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                int N = ReadInt();

                if (N == 0) break;

                int[] acc = new int[N + 1];

                for (int i = 1; i <= N; i++)
                    acc[i] = acc[i - 1] + ReadInt();

                int pos;

                if (acc[N] % 2 == 0 && (pos = Array.IndexOf(acc, acc[N] / 2)) != -1)
                    Console.WriteLine($"Sam stops at position {pos} and Ella stops at position {pos + 1}.");
                else
                    Console.WriteLine("No equal partitioning.");
            }
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
