namespace Algorithm.BOJ.BOJ_33178
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33178/input1.txt",
            "BOJ/BOJ_33178/input2.txt",
        ];

        public static void Run(string[] args)
        {
            Console.WriteLine(int.Parse(Console.ReadLine()!) / 10);
        }
    }
}
