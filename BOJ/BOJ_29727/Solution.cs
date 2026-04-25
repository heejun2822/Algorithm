namespace Algorithm.BOJ.BOJ_29727
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_29727/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] input = Console.ReadLine()!.Split();
            int xa = int.Parse(input[0]), ya = int.Parse(input[1]);
            input = Console.ReadLine()!.Split();
            int xb = int.Parse(input[0]), yb = int.Parse(input[1]);

            long cnt = (long)Math.Pow(n * (n + 1) / 2L, 2);

            int m = 0;

            if (xa == xb)
                m = Math.Abs(Math.Clamp(yb, -1, n) - Math.Clamp(ya, -1, n)) - 1;
            if (ya == yb)
                m = Math.Abs(Math.Clamp(xb, -1, n) - Math.Clamp(xa, -1, n)) - 1;

            cnt += m * (m + 1) / 2L * (n + 1);

            Console.WriteLine(cnt);
        }
    }
}
