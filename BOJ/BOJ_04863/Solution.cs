namespace Algorithm.BOJ.BOJ_04863
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04863/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine()!.Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]);

                if (a == -1 && b == -1) break;

                int s = CountCombination(a + b, a);
                int r = CountCombination(26 - (a + b), 13 - a);
                int t = CountCombination(26, 13);

                double p = (a == b ? 1.0 : 2.0) * s * r / t;

                Console.WriteLine($"{a}-{b} split: {p:F8}");
            }

            int CountCombination(int n, int k)
            {
                int cnt = 1;

                for (int i = n; i > k; i--)
                    cnt = cnt * i / (n - i + 1);

                return cnt;
            }
        }
    }
}
