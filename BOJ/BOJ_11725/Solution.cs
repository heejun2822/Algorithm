namespace Algorithm.BOJ.BOJ_11725
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11725/input1.txt",
            "BOJ/BOJ_11725/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            List<int>[] edgedNodes = new List<int>[N + 1];
            for (int i = 1; i <= N; i++) edgedNodes[i] = new();
            for (int _ = 0; _ < N - 1; _++)
            {
                int[] nodes = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                edgedNodes[nodes[0]].Add(nodes[1]);
                edgedNodes[nodes[1]].Add(nodes[0]);
            }

            int[] parentNodes = new int[N + 1];
            parentNodes[1] = -1;

            Stack<int> stack = new();
            stack.Push(1);

            while (stack.Count > 0)
            {
                int pn = stack.Pop();
                foreach (int node in edgedNodes[pn])
                {
                    if (parentNodes[node] != 0) continue;

                    parentNodes[node] = pn;
                    stack.Push(node);
                }
            }

            for (int i = 2; i <= N; i++) sw.WriteLine(parentNodes[i]);

            sr.Close();
            sw.Close();
        }
    }
}
