namespace Algorithm.BOJ.BOJ_05079
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05079/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                string productName = Console.ReadLine()!;

                if (productName == "#") break;

                string[] input = Console.ReadLine()!.Split();
                int PD = int.Parse(input[0]), PC = int.Parse(input[1]);
                double price = PD + PC / 100.0;

                int D = int.Parse(Console.ReadLine()!);
                (int B, int F)[] deals = new (int, int)[D];
                for (int i = 0; i < D; i++)
                {
                    input = Console.ReadLine()!.Split();
                    deals[i] = (int.Parse(input[0]), int.Parse(input[1]));
                }

                int E = int.Parse(Console.ReadLine()!);
                int[] quantities = new int[E];
                int maxQ = 0;
                for (int i = 0; i < E; i++)
                {
                    quantities[i] = int.Parse(Console.ReadLine()!);
                    maxQ = Math.Max(maxQ, quantities[i]);
                }

                int[] dp = new int[maxQ + 1];

                for (int i = 0; i <= maxQ; i++)
                    dp[i] = i;

                foreach ((int B, int F) in deals)
                    for (int i = B + 1; i <= maxQ; i++)
                        dp[i] = Math.Min(dp[i], dp[Math.Max(i - (B + F), 0)] + B);

                Console.WriteLine(productName);
                foreach (int q in quantities)
                {
                    double saved = (q - dp[q]) * price;
                    Console.WriteLine($"Buy {q}, save ${saved:F2}");
                }
                Console.WriteLine();
            }
        }
    }
}
