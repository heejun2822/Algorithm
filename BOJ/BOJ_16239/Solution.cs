namespace Algorithm.BOJ.BOJ_16239
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16239/input1.txt",
            "BOJ/BOJ_16239/input2.txt",
            "BOJ/BOJ_16239/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int K = int.Parse(Console.ReadLine()!);
            int N = int.Parse(Console.ReadLine()!);

            for (int i = 1; i < N; i++) Console.WriteLine(i);
            Console.WriteLine(K - N * (N - 1) / 2);
        }
    }
}
