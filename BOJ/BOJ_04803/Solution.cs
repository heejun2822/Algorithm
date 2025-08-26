namespace Algorithm.BOJ.BOJ_04803
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04803/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int caseNum = 1;

            List<int>[] edgeLists = {};
            bool[] visited = {};

            while (true)
            {
                string[] nm = sr.ReadLine()!.Split();
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);

                if (n == 0 && m == 0) break;

                edgeLists = new List<int>[n + 1];
                for (int i = 1; i <= n; i++) edgeLists[i] = new();
                for (int _ = 0; _ < m; _++)
                {
                    int[] nodes = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                    edgeLists[nodes[0]].Add(nodes[1]);
                    edgeLists[nodes[1]].Add(nodes[0]);
                }

                visited = new bool[n + 1];

                int T = 0;

                for (int i = 1; i <= n; i++)
                    if (IsTree(i, 0)) T++;

                sw.Write($"Case {caseNum++}: ");
                sw.WriteLine(
                    T switch {
                        0 => "No trees.",
                        1 => "There is one tree.",
                        _ => $"A forest of {T} trees."
                    }
                );
            }

            sr.Close();
            sw.Close();

            bool IsTree(int node, int parent)
            {
                if (visited[node]) return false;

                visited[node] = true;

                bool isTree = true;

                foreach (int edgedNode in edgeLists[node])
                {
                    if (edgedNode == parent) continue;
                    isTree &= IsTree(edgedNode, node);
                }

                return isTree;
            }
        }
    }
}
