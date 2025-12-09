namespace Algorithm.BOJ.BOJ_30396
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30396/input.txt",
        ];

        public static void Run(string[] args)
        {
            (int dr, int dc)[] moves = { (-2, -1), (-2, 1), (-1, -2), (-1, 2), (1, -2), (1, 2), (2, -1), (2, 1) };

            List<int>[] availableSquares = new List<int>[16];

            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    int idx = 4 * r + c;
                    availableSquares[idx] = new();

                    foreach ((int dr, int dc) in moves)
                    {
                        int nr = r + dr, nc = c + dc;
                        if (nr >= 0 && nr < 4 && nc >= 0 && nc < 4)
                            availableSquares[idx].Add(4 * nr + nc);
                    }
                }
            }

            int A = 0, B = 0;

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine()!;
                for (int j = 0; j < 4; j++)
                    if (input[j] == '1')
                        A |= 1 << (4 * i + j);
            }
            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine()!;
                for (int j = 0; j < 4; j++)
                    if (input[j] == '1')
                        B |= 1 << (4 * i + j);
            }

            Queue<int> queue = new();
            HashSet<int> visited = new();
            int cnt = 0;

            queue.Enqueue(A);
            visited.Add(A);

            while (queue.Count > 0)
            {
                int queueCnt = queue.Count;

                for (int _ = 0; _ < queueCnt; _++)
                {
                    int board = queue.Dequeue();

                    if (board == B)
                    {
                        Console.WriteLine(cnt);
                        return;
                    }

                    for (int i = 0; i < 16; i++)
                    {
                        if ((board & (1 << i)) == 0) continue;

                        foreach (int s in availableSquares[i])
                        {
                            if ((board & (1 << s)) != 0) continue;

                            int nextBoard = board;
                            nextBoard &= ~(1 << i);
                            nextBoard |= 1 << s;

                            if (visited.Add(nextBoard))
                                queue.Enqueue(nextBoard);
                        }
                    }
                }

                cnt++;
            }
        }
    }
}
