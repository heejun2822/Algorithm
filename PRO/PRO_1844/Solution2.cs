namespace Algorithm.PRO.PRO_1844 // 게임 맵 최단거리
{
    using System;
    using System.Collections.Generic;

    class Solution2
    {
        private static Solution2 Instance { get; } = new();

        public static string[] InputPaths { get; private set; } =
        [
            "PRO/PRO_1844/input1.txt",
            "PRO/PRO_1844/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int[][] _maps = System.Text.Json.JsonSerializer.Deserialize<int[][]>(Console.ReadLine()!)!;
            int[,] maps = new int[_maps.Length, _maps[0].Length];

            for (int i = 0; i < maps.GetLength(0); i++)
                for (int j = 0; j < maps.GetLength(1); j++)
                    maps[i, j] = _maps[i][j];

            Console.WriteLine(Instance.solution(maps));
        }

        public int solution(int[,] maps)
        {
            int n = maps.GetLength(0);
            int m = maps.GetLength(1);

            int[] dr = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, -1, 1 };

            Queue<(int r, int c)> queue = new Queue<(int, int)>();
            queue.Enqueue((0, 0));

            int cellCnt = 0;
            int queueCnt;

            while ((queueCnt = queue.Count) > 0)
            {
                cellCnt++;

                for (int _ = 0; _ < queueCnt; _++)
                {
                    (int r, int c) = queue.Dequeue();

                    if (r == n - 1 && c == m - 1)
                        return cellCnt;

                    for (int i = 0; i < 4; i++)
                    {
                        int nr = r + dr[i], nc = c + dc[i];

                        if (nr < 0 || nr >= n || nc < 0 || nc >= m || maps[nr, nc] == 0)
                            continue;

                        maps[nr, nc] = 0;
                        queue.Enqueue((nr, nc));
                    }
                }
            }

            return -1;
        }
    }
}
