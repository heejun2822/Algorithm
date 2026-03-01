namespace Algorithm.BOJ.BOJ_30961
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30961/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Array.Sort(A);

            long result = (long)A[0] * A[0];

            for (int i = 1; i < N; i++)
            {
                result ^= (long)A[i] * A[i];
                result ^= (long)A[i] * A[i - 1];
            }

            Console.WriteLine(result);
        }
    }
}
