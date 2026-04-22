namespace Algorithm.BOJ.BOJ_32206
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32206/input1.txt",
            "BOJ/BOJ_32206/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string S = Console.ReadLine()!;

            Console.WriteLine(26 + 25 * N);
        }
    }
}
