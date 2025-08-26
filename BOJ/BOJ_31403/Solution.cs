namespace Algorithm.BOJ.BOJ_31403
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31403/input.txt",
        ];

        public static void Run(string[] args)
        {
            string A = Console.ReadLine()!;
            string B = Console.ReadLine()!;
            string C = Console.ReadLine()!;

            Console.WriteLine(int.Parse(A) + int.Parse(B) - int.Parse(C));
            Console.WriteLine(int.Parse(A + B) - int.Parse(C));
        }
    }
}
