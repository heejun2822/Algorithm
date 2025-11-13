namespace Algorithm.BOJ.BOJ_15736
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15736/input1.txt",
            "BOJ/BOJ_15736/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            Console.WriteLine((int)Math.Sqrt(N));
        }
    }
}
