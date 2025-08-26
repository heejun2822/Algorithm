namespace Algorithm.BOJ.BOJ_01707
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01707/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int K = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < K; _++)
            {
                string[] ve = sr.ReadLine()!.Split();
                int V = int.Parse(ve[0]);
                int E = int.Parse(ve[1]);

                List<int>[] edges = new List<int>[V + 1];
                for (int i = 1; i <= V; i++) edges[i] = new();

                for (int __ = 0; __ < E; __++)
                {
                    string[] vertices = sr.ReadLine()!.Split();
                    int u = int.Parse(vertices[0]), v = int.Parse(vertices[1]);
                    edges[u].Add(v);
                    edges[v].Add(u);
                }

                int[] group = new int[V + 1];
                Stack<int> stack = new();

                for (int i = 1; i <= V; i++)
                {
                    if (group[i] != 0) continue;

                    group[i] = 1;
                    stack.Push(i);

                    while (stack.Count > 0)
                    {
                        int v = stack.Pop();

                        foreach (int u in edges[v])
                        {
                            if (group[u] == group[v])
                            {
                                sw.WriteLine("NO");
                                goto End;
                            }

                            if (group[u] == 0)
                            {
                                group[u] = group[v] == 1 ? 2 : 1;
                                stack.Push(u);
                            }
                        }
                    }
                }

                sw.WriteLine("YES");

                End:;
            }

            sr.Close();
            sw.Close();
        }
    }
}
