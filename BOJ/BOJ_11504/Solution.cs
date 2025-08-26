namespace Algorithm.BOJ.BOJ_11504
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11504/input.txt",
        ];

        private static int N = 1;
        private static int M = 1;
        private static int[] X = {};
        private static int[] Y = {};
        private static int[] wheel = {};

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                string[] nm = Console.ReadLine()!.Split();
                N = int.Parse(nm[0]);
                M = int.Parse(nm[1]);
                X = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                Y = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                wheel = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                int cnt = 0;
                for (int i = 0; i < N; i++)
                {
                    if (CheckLowerBound(i) && CheckUpperBound(i)) cnt++;
                }
                Console.WriteLine(cnt);
            }
        }

        private static bool CheckLowerBound(int offset)
        {
            for (int m = 0; m < M; m++)
            {
                int digit = wheel[(offset + m) % N];
                if (digit > X[m]) return true;
                else if (digit < X[m]) return false;
            }
            return true;
        }

        private static bool CheckUpperBound(int offset)
        {
            for (int m = 0; m < M; m++)
            {
                int digit = wheel[(offset + m) % N];
                if (digit < Y[m]) return true;
                else if (digit > Y[m]) return false;
            }
            return true;
        }
    }
}
