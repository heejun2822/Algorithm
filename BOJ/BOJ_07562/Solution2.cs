namespace Algorithm.BOJ.BOJ_07562
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_07562/input.txt",
        ];

        private static readonly int[] dr = { -2, -1, 1, 2, 2, 1, -1, -2 };
        private static readonly int[] dc = { 1, 2, 2, 1, -1, -2, -2, -1 };

        public static void Run(string[] args)
        {
            int tc = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < tc; _++)
            {
                int L = int.Parse(Console.ReadLine()!);
                string[] init = Console.ReadLine()!.Split();
                (int, int) I = (int.Parse(init[0]), int.Parse(init[1]));
                string[] goal = Console.ReadLine()!.Split();
                (int, int) G = (int.Parse(goal[0]), int.Parse(goal[1]));

                Console.WriteLine(CountMovements(L, I, G));
            }
        }

        private static int CountMovements(int L, (int r, int c) I, (int r, int c) G)
        {
            if (I == G) return 0;

            bool[,] visited = new bool[L, L];
            Queue<(int r, int c)> queue = new();
            int cnt = 0;

            visited[I.r, I.c] = true;
            queue.Enqueue(I);

            int queueCount;
            while ((queueCount = queue.Count) > 0)
            {
                cnt++;

                for (int _ = 0; _ < queueCount; _++)
                {
                    (int r, int c) = queue.Dequeue();

                    for (int d = 0; d < 8; d++)
                    {
                        int nr = r + dr[d];
                        int nc = c + dc[d];

                        if (nr < 0 || nr >= L || nc < 0 || nc >= L) continue;
                        if (visited[nr, nc]) continue;

                        if ((nr, nc) == G) return cnt;

                        visited[nr, nc] = true;
                        queue.Enqueue((nr, nc));
                    }
                }
            }

            return -1;
        }
    }
}
