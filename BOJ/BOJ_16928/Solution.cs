namespace Algorithm.BOJ.BOJ_16928
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16928/input1.txt",
            "BOJ/BOJ_16928/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            int[] board = Enumerable.Range(0, 101).ToArray();
            for (int _ = 0; _ < N; _++)
            {
                string[] ladder = Console.ReadLine()!.Split();
                int x = int.Parse(ladder[0]), y = int.Parse(ladder[1]);
                board[x] = y;
            }
            for (int _ = 0; _ < M; _++)
            {
                string[] snake = Console.ReadLine()!.Split();
                int u = int.Parse(snake[0]), v = int.Parse(snake[1]);
                board[u] = v;
            }

            bool[] visited = new bool[101];
            Queue<int> queue = new();

            visited[1] = true;
            queue.Enqueue(1);

            int queueCount;
            int cnt = 0;

            while ((queueCount = queue.Count) > 0)
            {
                cnt++;

                for (int _ = 0; _ < queueCount; _++)
                {
                    int pos = queue.Dequeue();

                    for (int dice = 1; dice <= 6; dice++)
                    {
                        if (pos + dice > 100) continue;

                        int nextPos = board[pos + dice];
                        if (visited[nextPos]) continue;

                        if (nextPos == 100)
                        {
                            Console.WriteLine(cnt);
                            return;
                        }

                        visited[nextPos] = true;
                        queue.Enqueue(nextPos);
                    }
                }
            }
        }
    }
}
