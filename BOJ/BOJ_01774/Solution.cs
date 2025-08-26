namespace Algorithm.BOJ.BOJ_01774
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01774/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            (int X, int Y)[] coords = new (int, int)[N + 1];
            (double len, int coord1, int coord2)[] paths = new (double, int, int)[N * (N - 1) / 2];

            int idx = 0;
            for (int i = 1; i <= N; i++)
            {
                string[] xy = sr.ReadLine()!.Split();
                int X = int.Parse(xy[0]);
                int Y = int.Parse(xy[1]);
                coords[i] = (X, Y);

                for (int j = 1; j < i; j++)
                {
                    double len = Math.Sqrt((double)(X - coords[j].X) * (X - coords[j].X) + (double)(Y - coords[j].Y) * (Y - coords[j].Y));
                    paths[idx++] = (len, j, i);
                }
            }
            Array.Sort(paths);

            int[] roots = new int[N + 1];
            Array.Fill(roots, -1);

            for (int _ = 0; _ < M; _++)
            {
                string[] connectedPath = sr.ReadLine()!.Split();
                Union(int.Parse(connectedPath[0]), int.Parse(connectedPath[1]));
            }

            double minPathLen = 0;

            foreach ((double len, int coord1, int coord2) in paths)
                if (Union(coord1, coord2)) minPathLen += len;

            sw.WriteLine(minPathLen.ToString("F2"));

            sr.Close();
            sw.Close();

            bool Union(int A, int B)
            {
                A = Find(A);
                B = Find(B);

                if (A == B) return false;

                if (roots[A] == roots[B]) roots[A]--;

                if (roots[A] < roots[B]) roots[B] = A;
                else roots[A] = B;

                return true;
            }

            int Find(int A)
            {
                return roots[A] < 0 ? A : (roots[A] = Find(roots[A]));
            }
        }
    }
}
