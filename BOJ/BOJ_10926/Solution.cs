namespace Algorithm.BOJ.BOJ_10926
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10926/input1.txt",
            "BOJ/BOJ_10926/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string id = Console.ReadLine() ?? "";
            Console.WriteLine(id + "??!");
        }
    }
}
