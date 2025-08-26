namespace Algorithm.BOJ.BOJ_02293
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02293/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            int[] coins = new int[n];
            for (int i = 0; i < n; i++) coins[i] = int.Parse(Console.ReadLine()!);

            int[] counts = new int[k + 1];
            counts[0] = 1;
            foreach (int cv in coins)
                for (int i = cv; i <= k; i++)
                    counts[i] += counts[i - cv];

            Console.WriteLine(counts[k]);
        }
    }
}
