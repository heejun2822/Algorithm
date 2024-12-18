namespace Algorithm.BOJ.BOJ_02156
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02156/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] wines = new int[n];
            for (int i = 0; i < n; i++) wines[i] = int.Parse(Console.ReadLine()!);

            int[] maximums = new int[n];
            for (int i = 0; i < n; i++)
                maximums[i] = Math.Max(
                    i >= 1 ? maximums[i - 1] : 0,
                    Math.Max(
                        i >= 2 ? maximums[i - 2] : 0,
                        (i >= 3 ? maximums[i - 3] : 0) + (i >= 1 ? wines[i - 1] : 0)
                    ) + wines[i]
                );

            Console.WriteLine(maximums[n - 1]);
        }
    }
}
