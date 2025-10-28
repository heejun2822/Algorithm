namespace Algorithm.BOJ.BOJ_02631
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02631/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            List<int> LIS = new();

            for (int _ = 0; _ < N; _++)
            {
                int number = int.Parse(Console.ReadLine()!);

                if (LIS.Count == 0 || number > LIS[^1])
                {
                    LIS.Add(number);
                    continue;
                }

                int l = 0, r = LIS.Count - 1;

                while (l < r)
                {
                    int m = (l + r) / 2;
                    if (number < LIS[m])
                        r = m;
                    else
                        l = m + 1;
                }

                LIS[r] = number;
            }

            Console.WriteLine(N - LIS.Count);
        }
    }
}
