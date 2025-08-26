namespace Algorithm.BOJ.BOJ_15439
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15439/input1.txt",
            "BOJ/BOJ_15439/input2.txt",
            "BOJ/BOJ_15439/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine(N * N - N);
        }
    }
}
