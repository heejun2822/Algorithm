namespace Algorithm.BOJ.BOJ_02501
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02501/input1.txt",
            "BOJ/BOJ_02501/input2.txt",
            "BOJ/BOJ_02501/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);
            Console.WriteLine(FindFactor(N, K));
        }

        private static int FindFactor(int N, int K)
        {
            if (K == 1) return 1;
            int cnt = 1;
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0 && ++cnt == K) return i;
            }
            if (cnt == K - 1) return N;
            return 0;
        }
    }
}
