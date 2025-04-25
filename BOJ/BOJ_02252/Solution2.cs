namespace Algorithm.BOJ.BOJ_02252
{
    using System.Text;

    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02252/input1.txt",
            "BOJ/BOJ_02252/input2.txt",
        ];

        // 위상 정렬 (Topological Sort)
        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int M = ReadInt(sr);

            List<int>[] edgeLists = new List<int>[N + 1];

            for (int i = 1; i <= N; i++) edgeLists[i] = new();
            for (int _ = 0; _ < M; _++) edgeLists[ReadInt(sr)].Add(ReadInt(sr));

            bool[] visited = new bool[N + 1];
            Stack<int> stack = new();

            for (int node = 1; node <= N; node++) DFS(node);

            StringBuilder sequence = new();

            while (stack.Count > 0) sequence.Append(stack.Pop()).Append(' ');

            sw.WriteLine(sequence);

            sr.Close();
            sw.Close();

            void DFS(int node)
            {
                if (visited[node]) return;

                visited[node] = true;

                foreach (int nextNode in edgeLists[node]) DFS(nextNode);

                stack.Push(node);
            }
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
