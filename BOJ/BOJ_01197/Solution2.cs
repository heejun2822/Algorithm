namespace Algorithm.BOJ.BOJ_01197
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01197/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] ve = sr.ReadLine()!.Split();
            int V = int.Parse(ve[0]);
            int E = int.Parse(ve[1]);

            List<(int B, int C)>[] edgeLists = new List<(int, int)>[V + 1];
            for (int i = 1; i <= V; i++) edgeLists[i] = new();
            for (int _ = 0; _ < E; _++)
            {
                int[] abc = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                edgeLists[abc[0]].Add((abc[1], abc[2]));
                edgeLists[abc[1]].Add((abc[0], abc[2]));
            }

            sw.WriteLine(Prim(V, edgeLists));

            sr.Close();
            sw.Close();
        }

        // 최소 신장 트리 (Minimum Spanning Tree, MST)
        // 프림 (Prim)
        private static int Prim(int V, List<(int B, int C)>[] edgeLists)
        {
            bool[] visited = new bool[V + 1];

            PriorityQueue<int, int> priorityQueue = new();
            priorityQueue.Enqueue(1, 0);

            int mstC = 0;

            while (priorityQueue.TryDequeue(out int A, out int P))
            {
                if (visited[A]) continue;

                visited[A] = true;
                mstC += P;

                foreach ((int B, int C) in edgeLists[A])
                    if (!visited[B]) priorityQueue.Enqueue(B, C);
            }

            return mstC;
        }
    }
}
