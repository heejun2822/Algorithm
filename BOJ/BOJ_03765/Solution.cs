namespace Algorithm.BOJ.BOJ_03765
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03765/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                string equation = Console.ReadLine()!;
                if (equation == null) return;
                Console.WriteLine(equation);
            }
        }
    }
}
