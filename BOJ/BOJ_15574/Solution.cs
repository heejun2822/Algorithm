namespace Algorithm.BOJ.BOJ_15574
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15574/input.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<int, (int minY, int maxY)> coords = new();

            int N = int.Parse(Console.ReadLine()!);

            while (N-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                if (!coords.TryAdd(x, (y, y)))
                    coords[x] = (Math.Min(coords[x].minY, y), Math.Max(coords[x].maxY, y));
            }

            int[] xArr = coords.Keys.ToArray();
            Array.Sort(xArr);

            int len = xArr.Length;
            double[,] dp = new double[len, 2];

            for (int i = 1; i < len; i++)
            {
                int currX = xArr[i];
                int currMinY = coords[currX].minY, currMaxY = coords[currX].maxY;
                int prevX = xArr[i - 1];
                int prevMinY = coords[prevX].minY, prevMaxY = coords[prevX].maxY;

                dp[i, 0] = Math.Max(
                    dp[i - 1, 0] + Distance(currX, currMinY, prevX, prevMinY),
                    dp[i - 1, 1] + Distance(currX, currMinY, prevX, prevMaxY)
                );
                dp[i, 1] = Math.Max(
                    dp[i - 1, 0] + Distance(currX, currMaxY, prevX, prevMinY),
                    dp[i - 1, 1] + Distance(currX, currMaxY, prevX, prevMaxY)
                );
            }

            Console.WriteLine(Math.Max(dp[len - 1, 0], dp[len - 1, 1]));

            double Distance(int x1, int y1, int x2, int y2)
            {
                double dx = x2 - x1;
                double dy = y2 - y1;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }
    }
}
