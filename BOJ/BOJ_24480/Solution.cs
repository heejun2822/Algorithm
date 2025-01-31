namespace Algorithm.BOJ.BOJ_24480
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_24480/input.txt",
        ];

        private static List<int>[] edges = {};
        private static int[] visited = {};
        private static int order = 1;

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nmr = sr.ReadLine()!.Split();
            int N = int.Parse(nmr[0]);
            int M = int.Parse(nmr[1]);
            int R = int.Parse(nmr[2]);

            edges = new List<int>[N + 1];
            for (int _ = 0; _ < M; _++)
            {
                string[] uv = sr.ReadLine()!.Split();
                int u = int.Parse(uv[0]), v = int.Parse(uv[1]);

                edges[u] ??= new();
                edges[u].Add(v);
                edges[v] ??= new();
                edges[v].Add(u);
            }
            for (int i = 1; i <= N; i++) edges[i]?.Sort((a, b) => b - a);

            visited = new int[N + 1];

            DFS(R);

            for (int i = 1; i <= N; i++) sw.WriteLine(visited[i]);

            sr.Close();
            sw.Close();
        }

        private static void DFS(int v)
        {
            if (visited[v] > 0) return;

            visited[v] = order++;
            edges[v]?.ForEach(DFS);
        }
    }
}
