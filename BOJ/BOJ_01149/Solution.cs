namespace Algorithm.BOJ.BOJ_01149
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01149/input1.txt",
            "BOJ/BOJ_01149/input2.txt",
            "BOJ/BOJ_01149/input3.txt",
            "BOJ/BOJ_01149/input4.txt",
            "BOJ/BOJ_01149/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[,] costs = new int[N, 3];
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                for (int j = 0; j < 3; j++) costs[i, j] = int.Parse(input[j]);
            }

            for (int i = 1; i < N; i++)
            for (int j = 0; j < 3; j++)
                costs[i, j] += Math.Min(costs[i - 1, (j + 1) % 3], costs[i - 1, (j + 2) % 3]);

            Console.WriteLine(Math.Min(Math.Min(costs[N - 1, 0], costs[N - 1, 1]), costs[N - 1, 2]));
        }
    }
}
