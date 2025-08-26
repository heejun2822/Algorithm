namespace Algorithm.BOJ.BOJ_06549
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06549/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()!) != "0")
            {
                string[] numbers = input.Split();
                int n = int.Parse(numbers[0]);
                int[] h = new int[n];
                for (int i = 0; i < n; i++) h[i] = int.Parse(numbers[i + 1]);

                Console.WriteLine(FindMaxExtent(h, 0, n - 1));
            }
        }

        private static long FindMaxExtent(int[] heights, int s, int e)
        {
            if (s == e) return heights[s];

            int m = (s + e) / 2;
            long maxExtent = Math.Max(
                FindMaxExtent(heights, s, m),
                FindMaxExtent(heights, m + 1, e)
            );

            int l = m;
            int r = m;
            int h = heights[m];
            while (l > s && r < e)
            {
                h = heights[l - 1] > heights[r + 1]
                    ? Math.Min(h, heights[--l])
                    : Math.Min(h, heights[++r]);
                maxExtent = Math.Max(maxExtent, (long)h * (r - l + 1));
            }
            while (l > s)
            {
                h = Math.Min(h, heights[--l]);
                maxExtent = Math.Max(maxExtent, (long)h * (r - l + 1));
            }
            while (r < e)
            {
                h = Math.Min(h, heights[++r]);
                maxExtent = Math.Max(maxExtent, (long)h * (r - l + 1));
            }

            return maxExtent;
        }
    }
}
