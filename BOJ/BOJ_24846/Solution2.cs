namespace Algorithm.BOJ.BOJ_24846
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24846/input1.txt",
            "BOJ/BOJ_24846/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr), m = ReadInt(sr);

            List<int>[] passageList = new List<int>[n + 1];

            for (int i = 0; i <= n; i++)
                passageList[i] = new();

            for (int _ = 0; _ < m; _++)
            {
                int u = ReadInt(sr), v = ReadInt(sr);
                passageList[u].Add(v);
                passageList[v].Add(u);
            }

            int x = ReadInt(sr);

            int[] a = new int[n + 1];

            for (int i = 1; i <= n; i++)
                a[i] = ReadInt(sr);

            // 0-1 BFS (0-1 너비 우선 탐색)

            int[] maxCloneCnt = new int[n + 1];
            LinkedList<int> deque = new();
            bool[] visited = new bool[n + 1];

            maxCloneCnt[0] = x;
            deque.AddFirst(0);
            passageList[0].Add(1);

            while (deque.Count > 0)
            {
                int room = deque.First!.Value;
                deque.RemoveFirst();

                if (visited[room]) continue;

                visited[room] = true;

                foreach (int nextRoom in passageList[room])
                {
                    if (visited[nextRoom]) continue;

                    bool zeroW = maxCloneCnt[room] > a[nextRoom];
                    int cloneCnt = zeroW ? maxCloneCnt[room] : maxCloneCnt[room] / 2;

                    if (cloneCnt > maxCloneCnt[nextRoom])
                    {
                        maxCloneCnt[nextRoom] = cloneCnt;
                        if (zeroW)
                            deque.AddFirst(nextRoom);
                        else
                            deque.AddLast(nextRoom);
                    }
                }
            }

            sw.WriteLine(maxCloneCnt[n]);

            sr.Close();
            sw.Close();
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
