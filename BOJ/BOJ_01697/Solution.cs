namespace Algorithm.BOJ.BOJ_01697
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01697/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            if (N == K)
            {
                Console.WriteLine("0");
                return;
            }

            bool[] visited = new bool[100_001];
            Queue<(int x, int t)> queue = new();

            visited[N] = true;
            queue.Enqueue((N, 0));

            int[] nx = new int[3];
            while (queue.Count > 0)
            {
                (int x, int t) = queue.Dequeue();

                nx[0] = x + 1;
                nx[1] = x - 1;
                nx[2] = x * 2;

                for (int i = 0; i < 3; i++)
                {
                    if (nx[i] == K)
                    {
                        Console.WriteLine(t + 1);
                        return;
                    }

                    if (nx[i] >= 0 && nx[i] <= 100_000 && !visited[nx[i]])
                    {
                        visited[nx[i]] = true;
                        queue.Enqueue((nx[i], t + 1));
                    }
                }
            }
        }
    }
}
