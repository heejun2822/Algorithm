namespace Algorithm.BOJ.BOJ_01260
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01260/input1.txt",
            "BOJ/BOJ_01260/input2.txt",
            "BOJ/BOJ_01260/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nmv = sr.ReadLine()!.Split();
            int N = int.Parse(nmv[0]);
            int M = int.Parse(nmv[1]);
            int V = int.Parse(nmv[2]);

            List<int>[] edges = new List<int>[N + 1];
            for (int i = 1; i <= N; i++) edges[i] = new();

            for (int _ = 0; _ < M; _++)
            {
                string[] vertices = sr.ReadLine()!.Split();
                int v1 = int.Parse(vertices[0]), v2 = int.Parse(vertices[1]);
                edges[v1].Add(v2);
                edges[v2].Add(v1);
            }
            for (int i = 1; i <= N; i++) edges[i].Sort();

            DFS(N, edges, V, sw);
            BFS(N, edges, V, sw);

            sr.Close();
            sw.Close();
        }

        // 깊이 우선 탐색 (DFS)
        private static void DFS(int N, List<int>[] E, int S, StreamWriter sw)
        {
            bool[] visited = new bool[N + 1];
            Stack<int> stack = new();

            stack.Push(S);

            while (stack.Count > 0)
            {
                int v = stack.Pop();
                if (visited[v]) continue;

                visited[v] = true;
                sw.Write(v + " ");
                for (int i = 1; i <= E[v].Count; i++)
                {
                    stack.Push(E[v][^i]);
                }
            }

            sw.Write("\n");
        }

        // 너비 우선 탐색 (BFS)
        private static void BFS(int N, List<int>[] E, int S, StreamWriter sw)
        {
            bool[] visited = new bool[N + 1];
            Queue<int> queue = new();

            visited[S] = true;
            sw.Write(S + " ");
            queue.Enqueue(S);

            while (queue.Count > 0)
            {
                int v = queue.Dequeue();
                for (int i = 0; i < E[v].Count; i++)
                {
                    if (visited[E[v][i]]) continue;

                    visited[E[v][i]] = true;
                    sw.Write(E[v][i] + " ");
                    queue.Enqueue(E[v][i]);
                }
            }

            sw.Write("\n");
        }
    }
}
