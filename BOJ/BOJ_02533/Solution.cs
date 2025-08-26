namespace Algorithm.BOJ.BOJ_02533
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02533/input1.txt",
            "BOJ/BOJ_02533/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            List<int>[] edgeLists = new List<int>[N + 1];
            for (int i = 1; i <= N; i++) edgeLists[i] = new();
            for (int _ = 0; _ < N - 1; _++)
            {
                string[] uv = sr.ReadLine()!.Split();
                int u = int.Parse(uv[0]);
                int v = int.Parse(uv[1]);
                edgeLists[u].Add(v);
                edgeLists[v].Add(u);
            }

            int[,] minEarlyAdapters = new int[N + 1, 2];
            MeasureMinEA(1, 0);

            sw.WriteLine(Math.Min(minEarlyAdapters[1, 0], minEarlyAdapters[1, 1]));

            sr.Close();
            sw.Close();

            void MeasureMinEA(int node, int parent)
            {
                minEarlyAdapters[node, 1] = 1;

                foreach (int child in edgeLists[node])
                {
                    if (child == parent) continue;

                    MeasureMinEA(child, node);
                    minEarlyAdapters[node, 0] += minEarlyAdapters[child, 1];
                    minEarlyAdapters[node, 1] += Math.Min(minEarlyAdapters[child, 0], minEarlyAdapters[child, 1]);
                }
            }
        }
    }
}
