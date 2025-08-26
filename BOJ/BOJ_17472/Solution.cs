namespace Algorithm.BOJ.BOJ_17472
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17472/input1.txt",
            "BOJ/BOJ_17472/input2.txt",
            "BOJ/BOJ_17472/input3.txt",
            "BOJ/BOJ_17472/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            int[,] map = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    map[i, j] = Console.Read() == '0' ? 0 : -1;
                    while (true)
                    {
                        int c = Console.Read();
                        if (c == ' ' || c == '\n' || c == -1) break;
                    }
                }
            }

            List<(int r, int c)>[] islands = new List<(int, int)>[7];
            for (int i = 1; i <= 6; i++) islands[i] = new();

            int islandIdx = 1;
            for (int r = 0; r < N; r++)
                for (int c = 0; c < M; c++)
                    if (SearchIsland(r, c)) islandIdx++;

            PriorityQueue<int, int> bridges = new();
            bridges.Enqueue(1, 0);

            bool[] visited = new bool[islandIdx];
            int minLen = 0;

            while (bridges.TryDequeue(out int idx, out int len))
            {
                if (visited[idx]) continue;

                visited[idx] = true;
                minLen += len;

                foreach ((int r, int c) in islands[idx])
                {
                    SearchBridge(r + 1, c, 1, 0, 0);
                    SearchBridge(r - 1, c, -1, 0, 0);
                    SearchBridge(r, c + 1, 0, 1, 0);
                    SearchBridge(r, c - 1, 0, -1, 0);
                }
            }

            for (int i = 1; i < islandIdx; i++)
            {
                if (!visited[i])
                {
                    Console.WriteLine("-1");
                    return;
                }
            }
            Console.WriteLine(minLen);

            bool SearchIsland(int r, int c)
            {
                if (map[r, c] != -1) return false;

                map[r, c] = islandIdx;
                islands[islandIdx].Add((r, c));

                if (r + 1 < N) SearchIsland(r + 1, c);
                if (r - 1 >= 0) SearchIsland(r - 1, c);
                if (c + 1 < M) SearchIsland(r, c + 1);
                if (c - 1 >= 0) SearchIsland(r, c - 1);

                return true;
            }

            void SearchBridge(int r, int c, int dr, int dc, int l)
            {
                if (r < 0 || r >= N || c < 0 || c >= M) return;

                if (map[r, c] == 0)
                    SearchBridge(r + dr, c + dc, dr, dc, l + 1);
                else if (l >= 2 && !visited[map[r, c]])
                    bridges.Enqueue(map[r, c], l);
            }
        }
    }
}
