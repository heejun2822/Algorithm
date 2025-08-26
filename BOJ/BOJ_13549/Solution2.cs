namespace Algorithm.BOJ.BOJ_13549
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13549/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            int L = 100_000;

            int[] visited = new int[L + 1];
            Array.Fill(visited, -1);
            Queue<int> queue = new();

            visited[N] = 0;
            queue.Enqueue(N);

            while (queue.Count > 0)
            {
                int x = queue.Dequeue();

                if (x == K)
                {
                    Console.WriteLine(visited[x]);
                    return;
                }

                if (x * 2 <= L && visited[x * 2] == -1)
                {
                    visited[x * 2] = visited[x];
                    queue.Enqueue(x * 2);
                }
                if (x - 1 >= 0 && visited[x - 1] == -1)
                {
                    visited[x - 1] = visited[x] + 1;
                    queue.Enqueue(x - 1);
                }
                if (x + 1 <= L && visited[x + 1] == -1)
                {
                    visited[x + 1] = visited[x] + 1;
                    queue.Enqueue(x + 1);
                }
            }
        }
    }
}
