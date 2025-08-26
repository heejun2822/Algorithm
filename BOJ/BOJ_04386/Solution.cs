namespace Algorithm.BOJ.BOJ_04386
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04386/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int[] roots = new int[n];
            Array.Fill(roots, -1);

            (float x, float y)[] stars = new (float, float)[n];
            (float cost, int star1, int star2)[] lines = new (float, int, int)[n * (n - 1) / 2];

            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                string[] xy = Console.ReadLine()!.Split();
                float x = float.Parse(xy[0]);
                float y = float.Parse(xy[1]);
                stars[i] = (x, y);

                for (int j = 0; j < i; j++)
                {
                    float cost = MathF.Sqrt(MathF.Pow(x - stars[j].x, 2) + MathF.Pow(y - stars[j].y, 2));
                    lines[idx++] = (cost, j, i);
                }
            }

            Array.Sort(lines);

            float minCost = 0;

            foreach ((float cost, int star1, int star2) in lines)
                if (Union(star1, star2)) minCost += cost;

            Console.WriteLine(minCost);

            bool Union(int s1, int s2)
            {
                s1 = Find(s1);
                s2 = Find(s2);

                if (s1 == s2) return false;

                if (roots[s1] == roots[s2]) roots[s1]--;

                if (roots[s1] < roots[s2]) roots[s2] = s1;
                else roots[s1] = s2;

                return true;
            }

            int Find(int s)
            {
                return roots[s] < 0 ? s : (roots[s] = Find(roots[s]));
            }
        }
    }
}
