namespace Algorithm.BOJ.BOJ_02338
{
    using System.Numerics;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02338/input.txt",
        ];

        public static void Run(string[] args)
        {
            BigInteger A = BigInteger.Parse(Console.ReadLine()!);
            BigInteger B = BigInteger.Parse(Console.ReadLine()!);

            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
        }
    }
}
