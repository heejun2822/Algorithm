namespace Algorithm.BOJ.BOJ_01271
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01271/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            System.Numerics.BigInteger n = System.Numerics.BigInteger.Parse(input[0]);
            System.Numerics.BigInteger m = System.Numerics.BigInteger.Parse(input[1]);

            Console.WriteLine(n / m);
            Console.WriteLine(n % m);
        }
    }
}
