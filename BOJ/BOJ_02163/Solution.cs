namespace Algorithm.BOJ.BOJ_02163
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02163/input1.txt",
            "BOJ/BOJ_02163/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            Console.WriteLine(N * M - 1);
        }
    }
}
