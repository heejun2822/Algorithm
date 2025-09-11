namespace Algorithm.BOJ.BOJ_31846
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31846/input1.txt",
            "BOJ/BOJ_31846/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string S = Console.ReadLine()!;

            int[][] scores = new int[N][];

            for (int idx = 1; idx < N; idx++)
            {
                int maxLen = Math.Min(idx, N - idx);
                scores[idx] = new int[maxLen + 1];

                for (int len = 1; len <= maxLen; len++)
                {
                    scores[idx][len] = scores[idx][len - 1] + (S[idx - len] == S[idx + len - 1] ? 1 : 0);
                }
            }

            int Q = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < Q; _++)
            {
                string[] input = Console.ReadLine()!.Split();
                int l = int.Parse(input[0]), r = int.Parse(input[1]);

                int maxScore = 0;

                for (int idx = l; idx < r; idx++)
                {
                    int len = Math.Min(idx - l + 1, r - idx);
                    maxScore = Math.Max(maxScore, scores[idx][len]);
                }

                Console.WriteLine(maxScore);
            }
        }
    }
}
