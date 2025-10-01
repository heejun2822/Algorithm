namespace Algorithm.BOJ.BOJ_17009
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17009/input1.txt",
            "BOJ/BOJ_17009/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int scoreA = 3 * int.Parse(Console.ReadLine()!) + 2 * int.Parse(Console.ReadLine()!) + int.Parse(Console.ReadLine()!);
            int scoreB = 3 * int.Parse(Console.ReadLine()!) + 2 * int.Parse(Console.ReadLine()!) + int.Parse(Console.ReadLine()!);
            Console.WriteLine(scoreA > scoreB ? 'A' : scoreA < scoreB ? 'B' : 'T');
        }
    }
}
