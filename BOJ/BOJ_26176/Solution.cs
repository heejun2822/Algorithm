namespace Algorithm.BOJ.BOJ_26176
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26176/input1.txt",
            "BOJ/BOJ_26176/input2.txt",
        ];

        // 시간 초과
        public static void Run(string[] args)
        {
            int s = int.Parse(Console.ReadLine()!);

            int maxExtent = (int)Math.Ceiling(Math.Sqrt(s) / 2);
            double maxRadius = maxExtent * Math.Sqrt(2);

            List<int> sqrRadii = new();

            for (int x = 1; x <= maxExtent; x++)
            {
                for (int y = x; y >= 1; y--)
                {
                    int sqrRadius = x * x + y * y;
                    if (sqrRadius * Math.PI < s) break;
                    sqrRadii.Add(sqrRadius);
                }
            }
            for (int x = maxExtent + 1; x <= maxRadius; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    int sqrRadius = x * x + y * y;
                    if (sqrRadius > maxRadius * maxRadius) break;
                    sqrRadii.Add(sqrRadius);
                }
            }

            sqrRadii.Sort();

            int l = 0, r = sqrRadii.Count - 1;

            while (l < r)
            {
                int m = (l + r) / 2;
                double radius = Math.Sqrt(sqrRadii[m]);
                int cnt = 0;

                for (int x = 1; x < radius; x++)
                    cnt += (int)Math.Sqrt(sqrRadii[m] - x * x);

                if (cnt * 4 < s)
                    l = m + 1;
                else
                    r = m;
            }

            Console.WriteLine(Math.Sqrt(sqrRadii[r]));
        }
    }
}
