namespace Algorithm.BOJ.BOJ_15188
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15188/input.txt",
        ];

        // 문제 오류? 단일 배낭처럼 풀어도 통과됨
        public static void Run(string[] args)
        {
            int P = int.Parse(Console.ReadLine()!);

            for (int num = 1; num <= P; num++)
            {
                string[] input = Console.ReadLine()!.Split();
                int N = int.Parse(input[0]);
                int W1 = int.Parse(input[1]);
                int W2 = int.Parse(input[2]);
                int[] w = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                int W = W1 + W2;
                int[] maxV = new int[W + 1];

                for (int i = 0; i < N; i++)
                    for (int wt = W; wt >= w[i]; wt--)
                        maxV[wt] = Math.Max(maxV[wt], maxV[wt - w[i]] + v[i]);

                Console.WriteLine($"Problem {num}: {maxV[W]}");
            }
        }
    }
}
