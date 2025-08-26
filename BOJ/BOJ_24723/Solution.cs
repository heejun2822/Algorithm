namespace Algorithm.BOJ.BOJ_24723
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24723/input1.txt",
            "BOJ/BOJ_24723/input2.txt",
        ];

        public static void Run(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine()!);
            Console.WriteLine(1 << N);
        }
    }
}
