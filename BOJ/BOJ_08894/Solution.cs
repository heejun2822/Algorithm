namespace Algorithm.BOJ.BOJ_08894
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_08894/input.txt",
        ];

        public static void Run(string[] args)
        {
            (int s, int d)[] lines = { (1, 3), (4, 6), (7, 9), (1, 7), (2, 8), (3, 9), (1, 9), (3, 7) };

            int T = int.Parse(Console.ReadLine()!);

            while (T-- > 0)
            {
                List<int>[,] edgeLists = new List<int>[10, 2];
                for (int i = 1; i <= 9; i++)
                    for (int j = 0; j < 2; j++)
                        edgeLists[i, j] = new();

                int e = int.Parse(Console.ReadLine()!);
                HashSet<int> totalEdges = new(e);

                for (int _ = 0; _ < e; _++)
                {
                    int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                    int s = Math.Min(input[0], input[1]);
                    int d = Math.Max(input[0], input[1]);

                    if (lines.Contains((s, d)))
                    {
                        int m = (s + d) / 2;
                        edgeLists[s, 0].Add(m);
                        edgeLists[m, 0].Add(s);
                        edgeLists[d, 0].Add(m);
                        edgeLists[m, 0].Add(d);
                        totalEdges.Add((1 << s) | (1 << m));
                        totalEdges.Add((1 << m) | (1 << d));
                    }
                    else
                    {
                        edgeLists[s, 0].Add(d);
                        edgeLists[d, 0].Add(s);
                        totalEdges.Add((1 << s) | (1 << d));
                    }
                }

                foreach ((int s, int d) in lines)
                {
                    int m = (s + d) / 2;
                    if (edgeLists[s, 0].Contains(m) && edgeLists[d, 0].Contains(m))
                    {
                        edgeLists[s, 1].Add(d);
                        edgeLists[d, 1].Add(s);
                    }
                }

                bool[] visited = new bool[10];
                List<int> sequence = new(9);
                bool success = false;

                for (int p = 1; p <= 9; p++)
                {
                    if (TryPattern(p, edgeLists, visited, sequence, totalEdges))
                    {
                        success = true;
                        break;
                    }
                }

                Console.WriteLine(success ? string.Join(' ', sequence) : "IMPOSSIBLE");
            }

            bool TryPattern(int p, List<int>[,] edgeLists, bool[] visited, List<int> sequence, HashSet<int> remainingEdges)
            {
                visited[p] = true;
                sequence.Add(p);

                if (remainingEdges.Count == 0)
                    return true;

                foreach (int np in edgeLists[p, 0])
                {
                    if (!visited[np])
                    {
                        int edge = (1 << p) | (1 << np);
                        remainingEdges.Remove(edge);

                        if (TryPattern(np, edgeLists, visited, sequence, remainingEdges))
                            return true;

                        remainingEdges.Add(edge);
                    }
                }

                foreach (int np in edgeLists[p, 1])
                {
                    int m = (p + np) / 2;

                    if (!visited[np] && visited[m])
                    {
                        int edge1 = (1 << p) | (1 << m);
                        int edge2 = (1 << m) | (1 << np);
                        bool removed1 = remainingEdges.Remove(edge1);
                        bool removed2 = remainingEdges.Remove(edge2);

                        if(TryPattern(np, edgeLists, visited, sequence, remainingEdges))
                            return true;

                        if (removed1)
                            remainingEdges.Add(edge1);
                        if (removed2)
                            remainingEdges.Add(edge2);
                    }
                }

                visited[p] = false;
                sequence.RemoveAt(sequence.Count - 1);

                return false;
            }
        }
    }
}
