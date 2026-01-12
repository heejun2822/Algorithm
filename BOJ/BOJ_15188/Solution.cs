namespace Algorithm.BOJ.BOJ_15188
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15188/input.txt",
        ];

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

                int[,] maxV = new int[W1 + 1, W2 + 1];

                for (int i = 0; i < N; i++)
                {
                    for (int w1 = W1; w1 >= 0; w1--)
                    {
                        for (int w2 = W2; w2 >= 0; w2--)
                        {
                            if (w1 >= w[i])
                                maxV[w1, w2] = Math.Max(maxV[w1, w2], maxV[w1 - w[i], w2] + v[i]);
                            if (w2 >= w[i])
                                maxV[w1, w2] = Math.Max(maxV[w1, w2], maxV[w1, w2 - w[i]] + v[i]);
                        }
                    }
                }

                Console.WriteLine($"Problem {num}: {maxV[W1, W2]}");
            }
        }
    }
}
