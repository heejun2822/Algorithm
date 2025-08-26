namespace Algorithm.BOJ.BOJ_02743
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02743/input.txt",
        ];

        public static void Run(string[] args)
        {
            string word = Console.ReadLine()!;
            Console.WriteLine(word.Length);
        }
    }
}
