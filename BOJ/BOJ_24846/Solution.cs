namespace Algorithm.BOJ.BOJ_24846
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
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

            int[] maxCloneCnt = new int[n + 1];
            PriorityQueue<int, int> prQueue = new();
            bool[] visited = new bool[n + 1];

            prQueue.Enqueue(0, -(maxCloneCnt[0] = x));
            passageList[0].Add(1);

            while (prQueue.Count > 0)
            {
                int room = prQueue.Dequeue();

                if (visited[room]) continue;

                visited[room] = true;

                foreach (int nextRoom in passageList[room])
                {
                    if (visited[nextRoom]) continue;

                    int cloneCnt = maxCloneCnt[room] > a[nextRoom] ? maxCloneCnt[room] : maxCloneCnt[room] / 2;
                    if (cloneCnt > maxCloneCnt[nextRoom])
                        prQueue.Enqueue(nextRoom, -(maxCloneCnt[nextRoom] = cloneCnt));
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
