namespace Algorithm.BOJ.BOJ_26173
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26173/input1.txt",
            "BOJ/BOJ_26173/input2.txt",
        ];

        public static void Run(string[] args)
        {
            long a = long.Parse(Console.ReadLine()!);
            Console.WriteLine(Math.Sqrt(a / Math.PI) * 2);
        }
    }
}
