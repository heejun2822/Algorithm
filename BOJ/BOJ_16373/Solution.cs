namespace Algorithm.BOJ.BOJ_16373
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16373/input.txt",
        ];

        public static void Run(string[] args)
        {
            int tc = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < tc; _++)
            {
                int n = int.Parse(Console.ReadLine()!);
                (int u, int v)[] edges = new (int, int)[n - 1];
                for (int i = 0; i < n - 1; i++)
                {
                    string[] input = Console.ReadLine()!.Split();
                    edges[i] = (int.Parse(input[0]), int.Parse(input[1]));
                }

                int[] vertices = Enumerable.Range(1, n).ToArray();

                bool[,] badEdgeTable = new bool[n + 1, n + 1];
                for (int i = 1; i <= n; i++)
                {
                    badEdgeTable[i, i] = true;
                    for (int j = i + 1; j <= n; j++)
                    {
                        bool isBadEdge = false;
                        for (int d = 2; d <= i; d++)
                        {
                            if (i % d == 0 && j % d == 0)
                            {
                                isBadEdge = true;
                                break;
                            }
                        }
                        badEdgeTable[i, j] = badEdgeTable[j, i] = isBadEdge;
                    }
                }

                int[] output = new int[n];
                int min = n - 1;
                Permutation(vertices, edges, badEdgeTable, 0, output, ref min);

                Console.WriteLine(string.Join(' ', output));
            }
        }

        private static void Permutation(int[] vertices, (int u, int v)[] edges, bool[,] badEdgeTable, int idx, int[] output, ref int min)
        {
            if (idx == vertices.Length)
            {
                int cnt = 0;
                foreach ((int u, int v) in edges)
                {
                    if (badEdgeTable[vertices[u - 1], vertices[v - 1]]) cnt++;
                }
                if (cnt < min)
                {
                    min = cnt;
                    for (int i = 0; i < output.Length; i++) output[i] = vertices[i];
                }
                return;
            }

            for (int i = idx; i < vertices.Length; i++)
            {
                (vertices[idx], vertices[i]) = (vertices[i], vertices[idx]);
                Permutation(vertices, edges, badEdgeTable, idx + 1, output, ref min);
                (vertices[idx], vertices[i]) = (vertices[i], vertices[idx]);
            }
        }
    }
}
