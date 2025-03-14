namespace Algorithm.BOJ.BOJ_01197
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01197/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] ve = sr.ReadLine()!.Split();
            int V = int.Parse(ve[0]);
            int E = int.Parse(ve[1]);

            (int A, int B, int C)[] edges = new (int, int, int)[E];
            for (int i = 0; i < E; i++)
            {
                int[] abc = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                edges[i] = (abc[0], abc[1], abc[2]);
            }

            sw.WriteLine(Kruskal(V, edges));

            sr.Close();
            sw.Close();
        }

        // 최소 신장 트리 (Minimum Spanning Tree, MST)
        // 크루스칼 (Kruskal)
        private static int Kruskal(int V, (int A, int B, int C)[] edges)
        {
            Array.Sort(edges, (a, b) => a.C.CompareTo(b.C));

            int[] roots = new int[V + 1];
            Array.Fill(roots, -1);

            int mstC = 0;

            foreach ((int A, int B, int C) in edges)
                if (Union(roots, A, B)) mstC += C;

            return mstC;
        }

        private static bool Union(int[] roots, int A, int B)
        {
            A = Find(roots, A);
            B = Find(roots, B);

            if (A == B) return false;

            if (roots[A] == roots[B]) roots[A]--;

            if (roots[A] < roots[B]) roots[B] = A;
            else roots[A] = B;

            return true;
        }

        private static int Find(int[] roots, int A)
        {
            return roots[A] < 0 ? A : (roots[A] = Find(roots, roots[A]));
        }
    }
}
