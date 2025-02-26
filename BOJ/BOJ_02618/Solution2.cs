namespace Algorithm.BOJ.BOJ_02618
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02618/input.txt",
        ];

        private static int W;
        private static Pos[] pos = {};
        private static (int minDist, int movedPoliceCar)[,] memo = {};

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            W = int.Parse(sr.ReadLine()!);

            pos = new Pos[W + 2];
            pos[0] = new(1, 1);
            pos[1] = new(N, N);
            for (int i = 0; i < W; i++)
            {
                string[] rc = sr.ReadLine()!.Split();
                pos[i + 2] = new(int.Parse(rc[0]), int.Parse(rc[1]));
            }

            memo = new (int, int)[W + 2, W + 2];

            SearchMinDistance(0, 1);

            sw.WriteLine(memo[0, 1].minDist);

            int p1 = 0, p2 = 1;
            for (int p = 2; p < W + 2; p++)
            {
                sw.WriteLine(memo[p1, p2].movedPoliceCar);
                if (memo[p1, p2].movedPoliceCar == 1) p1 = p;
                else p2 = p;
            }

            sr.Close();
            sw.Close();
        }

        private static void SearchMinDistance(int p1, int p2)
        {
            if (memo[p1, p2].movedPoliceCar != 0) return;

            int np = Math.Max(p1, p2) + 1;

            if (np == W + 2) return;

            SearchMinDistance(np, p2);
            int dist1 = memo[np, p2].minDist + Pos.Distance(pos[p1], pos[np]);
            SearchMinDistance(p1, np);
            int dist2 = memo[p1, np].minDist + Pos.Distance(pos[p2], pos[np]);

            memo[p1, p2] = dist1 < dist2 ? (dist1, 1) : (dist2, 2);
        }

        private class Pos
        {
            public static int Distance(Pos pos1, Pos pos2)
            {
                return Math.Abs(pos2.r - pos1.r) + Math.Abs(pos2.c - pos1.c);
            }

            public readonly int r;
            public readonly int c;

            public Pos(int r, int c)
            {
                this.r = r;
                this.c = c;
            }
        }
    }
}
