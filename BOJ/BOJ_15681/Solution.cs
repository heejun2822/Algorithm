namespace Algorithm.BOJ.BOJ_15681
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15681/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nrq = sr.ReadLine()!.Split();
            int N = int.Parse(nrq[0]);
            int R = int.Parse(nrq[1]);
            int Q = int.Parse(nrq[2]);

            List<int>[] edgeLists = new List<int>[N + 1];
            for (int i = 1; i <= N; i++) edgeLists[i] = new();
            for (int _ = 0; _ < N - 1; _++)
            {
                string[] uv = sr.ReadLine()!.Split();
                int U = int.Parse(uv[0]);
                int V = int.Parse(uv[1]);
                edgeLists[U].Add(V);
                edgeLists[V].Add(U);
            }

            int[] sizes = new int[N + 1];
            MeasureTreeSize(R, 0);

            for (int _ = 0; _ < Q; _++)
                sw.WriteLine(sizes[int.Parse(sr.ReadLine()!)]);

            sr.Close();
            sw.Close();

            void MeasureTreeSize(int node, int parent)
            {
                sizes[node] = 1;
                foreach (int child in edgeLists[node])
                {
                    if (child == parent) continue;
                    MeasureTreeSize(child, node);
                    sizes[node] += sizes[child];
                }
            }
        }
    }
}
