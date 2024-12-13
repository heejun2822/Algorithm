namespace Algorithm.BOJ.BOJ_01904
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01904/input.txt",
        ];

        // 시간 초과
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int cnt = 0, n = 1, k = N;
            while (k >= 0)
            {
                cnt += H(n, k);
                n += 1;
                k -= 2;
            }

            Console.WriteLine(cnt % 15746);
        }

        private static int H(int n, int k)
        {
            return C(n + k - 1, k);
        }

        private static int C(int n, int k)
        {
            k = Math.Min(k, n - k);
            int ans = 1;
            for (int i = 1; i <= k; i++) ans = ans * (n - i + 1) / i;
            return ans;
        }
    }
}
