namespace Algorithm.BOJ.BOJ_27959
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27959/input1.txt",
            "BOJ/BOJ_27959/input2.txt",
            "BOJ/BOJ_27959/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            Console.WriteLine(100 * N >= M ? "Yes" : "No");
        }
    }
}
