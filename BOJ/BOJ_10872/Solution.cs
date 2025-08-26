namespace Algorithm.BOJ.BOJ_10872
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10872/input1.txt",
            "BOJ/BOJ_10872/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int factorial = 1;
            for (int i = 2; i <= N; i++) factorial *= i;
            Console.WriteLine(factorial);
        }
    }
}
