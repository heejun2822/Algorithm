namespace Algorithm.PRO.PRO_1844 // 게임 맵 최단거리
{
    using System;

    public class Solution : SolutionPRO<Solution>, ISolutionPRO
    {
        public static string[] InputPaths { get; set; } =
        [
            "PRO/PRO_1844/input1.txt",
            "PRO/PRO_1844/input2.txt",
        ];

        // 시간 초과
        public override void Run(string[] args)
        {
            int[][] _maps = System.Text.Json.JsonSerializer.Deserialize<int[][]>(Console.ReadLine()!)!;
            int[,] maps = new int[_maps.Length, _maps[0].Length];

            for (int i = 0; i < maps.GetLength(0); i++)
                for (int j = 0; j < maps.GetLength(1); j++)
                    maps[i, j] = _maps[i][j];

            int answer = solution(maps);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(answer));
        }

        public int solution(int[,] maps)
        {
            int n = maps.GetLength(0);
            int m = maps.GetLength(1);
            bool[,] visited = new bool[n, m];
            int minCnt = int.MaxValue;

            return DFS(maps, visited, n, m, 0, 0, 1, ref minCnt) ? minCnt : -1;
        }

        public bool DFS(int[,] maps, bool[,] visited, int n, int m, int r, int c, int cnt, ref int minCnt)
        {
            if (visited[r, c] || maps[r, c] == 0 || cnt >= minCnt)
                return false;

            if (r == n - 1 && c == m - 1)
            {
                minCnt = cnt;
                return true;
            }

            visited[r, c] = true;

            bool hasPath = false;

            if (r - 1 >= 0)
                hasPath |= DFS(maps, visited, n, m, r - 1, c, cnt + 1, ref minCnt);
            if (r + 1 < n)
                hasPath |= DFS(maps, visited, n, m, r + 1, c, cnt + 1, ref minCnt);
            if (c - 1 >= 0)
                hasPath |= DFS(maps, visited, n, m, r, c - 1, cnt + 1, ref minCnt);
            if (c + 1 < m)
                hasPath |= DFS(maps, visited, n, m, r, c + 1, cnt + 1, ref minCnt);

            visited[r, c] = false;

            return hasPath;
        }
    }
}
