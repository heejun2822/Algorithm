namespace Algorithm.BOJ.BOJ_13193
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13193/input1.txt",
            "BOJ/BOJ_13193/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M_lim = int.Parse(input[1]);
            int P_lim = int.Parse(input[2]);

            Console.WriteLine($"{2 * N + 1} {2 * N}");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {2 * N + 1}");
                Console.WriteLine($"{2 * N + 1} {N + i}");
            }
        }
    }
}
