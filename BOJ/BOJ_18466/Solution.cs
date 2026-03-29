namespace Algorithm.BOJ.BOJ_18466
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_18466/input1.txt",
            "BOJ/BOJ_18466/input2.txt",
            "BOJ/BOJ_18466/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]), k = int.Parse(input[1]);

            long[] a = new long[n + 1];

            input = Console.ReadLine()!.Split();
            for (int i = 1; i <= n; i++)
                a[i] = long.Parse(input[i - 1]);

            long mask = 0;
            int prevZeroCnt = k;
            long ans = 0;

            for (int i = 1; i <= n; i++)
            {
                mask |= a[i];

                int currZeroCnt = 0;

                for (int p = 0; p < k; p++)
                    if ((mask & (1L << p)) == 0)
                        currZeroCnt++;

                ans += i * (((1L << prevZeroCnt) - (1L << currZeroCnt)) % 998_244_353);
                ans %= 998_244_353;

                prevZeroCnt = currZeroCnt;
            }

            Console.WriteLine(ans);
        }
    }
}
