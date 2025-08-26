namespace Algorithm.BOJ.BOJ_02213
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02213/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);
            int[] w = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            List<int>[] edgeLists = new List<int>[n + 1];
            for (int i = 1; i <= n; i++) edgeLists[i] = new();
            for (int _ = 0; _ < n - 1; _++)
            {
                string[] nodes = sr.ReadLine()!.Split();
                int node1 = int.Parse(nodes[0]);
                int node2 = int.Parse(nodes[1]);
                edgeLists[node1].Add(node2);
                edgeLists[node2].Add(node1);
            }

            int[,] maxIndiSetSizes = new int[n + 1, 2];
            bool[] isIncluded = new bool[n + 1];
            MeasureMaxIndiSetSize(1, 0);

            List<int> maxIndiSet = new((n + 1) / 2);
            if (maxIndiSetSizes[1, 0] > maxIndiSetSizes[1, 1])
            {
                sw.WriteLine(maxIndiSetSizes[1, 0]);
                ComposeMaxIndiSet(1, 0, false);
            }
            else
            {
                sw.WriteLine(maxIndiSetSizes[1, 1]);
                ComposeMaxIndiSet(1, 0, true);
            }
            maxIndiSet.Sort();
            sw.WriteLine(string.Join(' ', maxIndiSet));

            sr.Close();
            sw.Close();

            void MeasureMaxIndiSetSize(int node, int parent)
            {
                maxIndiSetSizes[node, 1] = w[node - 1];

                foreach (int child in edgeLists[node])
                {
                    if (child == parent) continue;

                    MeasureMaxIndiSetSize(child, node);

                    if (maxIndiSetSizes[child, 0] > maxIndiSetSizes[child, 1])
                    {
                        maxIndiSetSizes[node, 0] += maxIndiSetSizes[child, 0];
                        isIncluded[child] = false;
                    }
                    else
                    {
                        maxIndiSetSizes[node, 0] += maxIndiSetSizes[child, 1];
                        isIncluded[child] = true;
                    }
                    maxIndiSetSizes[node, 1] += maxIndiSetSizes[child, 0];
                }
            }

            void ComposeMaxIndiSet(int node, int parent,  bool included)
            {
                if (included) maxIndiSet.Add(node);

                foreach (int child in edgeLists[node])
                {
                    if (child == parent) continue;

                    ComposeMaxIndiSet(child, node, included ? false : isIncluded[child]);
                }
            }
        }
    }
}
