namespace Algorithm.BOJ.BOJ_25494
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25494/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                int[] abc = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                Console.WriteLine(abc.Min());
            }
        }
    }
}
