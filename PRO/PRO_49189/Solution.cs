namespace Algorithm.PRO.PRO_49189 // 가장 먼 노드
{
    using System.Collections.Generic;

    public class Solution : SolutionPRO<Solution>, ISolutionPRO
    {
        public static string[] InputPaths { get; set; } =
        [
            "PRO/PRO_49189/input.txt",
        ];

        public override void Run(string[] args)
        {
            int n = System.Text.Json.JsonSerializer.Deserialize<int>(Console.ReadLine()!);

            int[][] _edge = System.Text.Json.JsonSerializer.Deserialize<int[][]>(Console.ReadLine()!)!;
            int[,] edge = new int[_edge.Length, _edge[0].Length];

            for (int i = 0; i < edge.GetLength(0); i++)
                for (int j = 0; j < edge.GetLength(1); j++)
                    edge[i, j] = _edge[i][j];

            int answer = solution(n, edge);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(answer));
        }

        public int solution(int n, int[,] edge)
        {
            List<int>[] edgeLists = new List<int>[n + 1];

            for (int i = 1; i <= n; i++)
                edgeLists[i] = new List<int>();

            for (int i = 0; i < edge.GetLength(0); i++)
            {
                int a = edge[i, 0], b = edge[i, 1];
                edgeLists[a].Add(b);
                edgeLists[b].Add(a);
            }

            bool[] visited = new bool[n + 1];
            Queue<int> queue = new Queue<int>();

            visited[1] = true;
            queue.Enqueue(1);

            int cnt = 0;

            while (queue.Count > 0)
            {
                cnt = queue.Count;

                for (int _ = 0; _ < cnt; _++)
                {
                    int u = queue.Dequeue();
                    foreach (int v in edgeLists[u])
                    {
                        if (!visited[v])
                        {
                            visited[v] = true;
                            queue.Enqueue(v);
                        }
                    }
                }
            }

            return cnt;
        }
    }
}
