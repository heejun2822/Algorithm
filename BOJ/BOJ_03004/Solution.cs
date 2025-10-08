namespace Algorithm.BOJ.BOJ_03004
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03004/input1.txt",
            "BOJ/BOJ_03004/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine((N / 2 + 1) * (N - N / 2 + 1));
        }
    }
}
