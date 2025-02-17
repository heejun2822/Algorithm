namespace Algorithm.BOJ.BOJ_13549
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_13549/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            int L = 100_000;

            int[] dist = new int[L + 1];
            Array.Fill(dist, int.MaxValue);
            dist[N] = 0;

            PriorityQueue<int, int> connected = new();

            connected.Enqueue(N, dist[N]);

            while (connected.Count > 0)
            {
                int x = connected.Dequeue();

                if (x == K) break;

                if (x - 1 >= 0 && dist[x] + 1 < dist[x - 1])
                    connected.Enqueue(x - 1, dist[x - 1] = dist[x] + 1);
                if (x + 1 <= L && dist[x] + 1 < dist[x + 1])
                    connected.Enqueue(x + 1, dist[x + 1] = dist[x] + 1);
                if (x * 2 <= L && dist[x] < dist[x * 2])
                    connected.Enqueue(x * 2, dist[x * 2] = dist[x]);
            }

            Console.WriteLine(dist[K]);
        }
    }
}
