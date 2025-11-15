namespace Algorithm.BOJ.BOJ_09307
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09307/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input;
            System.Text.StringBuilder output = new();

            while ((input = Console.ReadLine()!) != "-1")
            {
                string[] splited = input.Split();
                int N = int.Parse(splited[3]);
                double[] costs = new double[Math.Max(N + 1, 4)];

                for (int i = 1; i <= 3; i++)
                    costs[i] = double.Parse(splited[i - 1]);

                for (int i = 4; i <= N; i++)
                    costs[i] = Math.Round(costs[i - 3] * costs[i - 2] / costs[i - 1], 2, MidpointRounding.AwayFromZero);

                string c = costs[N].ToString("N2");
                output.AppendLine($"Month {N} cost: ${c}");
            }

            Console.Write(output);
        }
    }
}
