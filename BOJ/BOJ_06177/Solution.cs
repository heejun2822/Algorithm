namespace Algorithm.BOJ.BOJ_06177
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06177/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int[] X = new int[N];
            float sum = 0;

            for (int i = 0; i < N; i++)
            {
                X[i] = int.Parse(Console.ReadLine()!);
                sum += X[i];
            }
            Array.Sort(X);

            float mean = sum / N;
            float median = N % 2 == 1 ? X[N / 2] : (X[N / 2 - 1] + X[N / 2]) / 2f;

            Console.WriteLine(mean);
            Console.WriteLine(median);
        }
    }
}
