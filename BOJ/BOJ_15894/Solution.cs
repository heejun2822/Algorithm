namespace Algorithm.BOJ.BOJ_15894
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15894/input1.txt",
            "BOJ/BOJ_15894/input2.txt",
        ];

        public static void Run(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine()!);
            Console.WriteLine(n * 4);
        }
    }
}
