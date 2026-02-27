namespace Algorithm.BOJ.BOJ_28359
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28359/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Array.Sort(A);

            int sum = 0;
            int value = 0;
            int maxValue = 0;

            for (int i = 0; i < N; i++)
            {
                sum += A[i];
                if (i > 0 && A[i] == A[i - 1])
                    maxValue = Math.Max(maxValue, value += A[i]);
                else
                    maxValue = Math.Max(maxValue, value = A[i]);
            }

            Console.WriteLine(sum + maxValue);
            Console.WriteLine(string.Join(' ', A));
        }
    }
}
