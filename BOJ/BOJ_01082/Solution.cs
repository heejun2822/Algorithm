namespace Algorithm.BOJ.BOJ_01082
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01082/input1.txt",
            "BOJ/BOJ_01082/input2.txt",
            "BOJ/BOJ_01082/input3.txt",
            "BOJ/BOJ_01082/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] P = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int M = int.Parse(Console.ReadLine()!);

            string[] dp = new string[M + 1];
            Array.Fill(dp, "");

            for (int i = N - 1; i >= 0; i--)
                for (int j = P[i]; j <= M; j++)
                    dp[j] = GetBiggerNumber(dp[j], dp[j - P[i]].TrimStart('0') + i);

            Console.WriteLine(dp[M]);

            string GetBiggerNumber(string A, string B)
            {
                if (A.Length > B.Length)
                    return A;
                if (A.Length < B.Length)
                    return B;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > B[i])
                        return A;
                    if (A[i] < B[i])
                        return B;
                }

                return A;
            }
        }
    }
}
