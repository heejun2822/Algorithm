namespace Algorithm.BOJ.BOJ_01967
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01967/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);

            List<(int child, int weight)>[] edgeLists = new List<(int, int)>[n + 1];
            for (int i = 1; i <= n; i++) edgeLists[i] = new();
            for (int _ = 0; _ < n - 1; _++)
            {
                int[] info = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                edgeLists[info[0]].Add((info[1], info[2]));
            }

            int diameter = 0;
            DFS(1);

            sw.WriteLine(diameter);

            sr.Close();
            sw.Close();

            int DFS(int node)
            {
                int maxW = 0;

                foreach ((int child, int weight) in edgeLists[node])
                {
                    int w = weight + DFS(child);
                    diameter = Math.Max(diameter, maxW + w);
                    maxW = Math.Max(maxW, w);
                }

                return maxW;
            }
        }
    }
}
