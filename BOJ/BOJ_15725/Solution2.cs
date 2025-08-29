namespace Algorithm.BOJ.BOJ_15725
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15725/input.txt",
        ];

        public static void Run(string[] args)
        {
            string polynomial = Console.ReadLine()!;

            string differential = polynomial.Contains('x') ? polynomial.Split('x')[0] : "0";

            if (differential == "" || differential == "-")
                differential += "1";

            Console.WriteLine(differential);
        }
    }
}
