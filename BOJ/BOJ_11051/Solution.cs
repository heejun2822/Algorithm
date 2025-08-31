namespace Algorithm.BOJ.BOJ_11051
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11051/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            System.Numerics.BigInteger output = 1;

            for (int i = 0; i < K; i++)
                output = output * (N - i) / (i + 1);

            Console.WriteLine(output % 10007);
        }
    }
}
