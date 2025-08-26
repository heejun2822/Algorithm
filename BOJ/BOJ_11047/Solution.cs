namespace Algorithm.BOJ.BOJ_11047
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11047/input1.txt",
            "BOJ/BOJ_11047/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);
            int[] A = new int[N];
            for (int i = 0; i < N; i++) A[i] = int.Parse(Console.ReadLine()!);

            int cnt = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                cnt += K / A[i];
                K %= A[i];
            }

            Console.WriteLine(cnt);
        }
    }
}
