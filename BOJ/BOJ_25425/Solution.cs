namespace Algorithm.BOJ.BOJ_25425
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25425/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            long a = long.Parse(input[2]);
            int K = int.Parse(input[3]);

            int max = (int)Math.Min(a - K, N - 1) + 1;
            int min = Math.Min((int)Math.Ceiling((a - K) / (double)M), N - 1) + 1;

            Console.WriteLine($"{max} {min}");
        }
    }
}
