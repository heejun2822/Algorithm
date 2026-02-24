namespace Algorithm.BOJ.BOJ_01005
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01005/input1.txt",
            "BOJ/BOJ_01005/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            while (T-- > 0)
            {
                int N = ReadInt(sr), K = ReadInt(sr);
                int[] D = new int[N + 1];

                for (int i = 1; i <= N; i++)
                    D[i] = ReadInt(sr);

                List<int>[] prevLists = new List<int>[N + 1];
                List<int>[] nextLists = new List<int>[N + 1];
                int[] inDegrees = new int[N + 1];

                for (int i = 1; i <= N; i++)
                {
                    prevLists[i] = new();
                    nextLists[i] = new();
                }

                while (K-- > 0)
                {
                    int X = ReadInt(sr), Y = ReadInt(sr);
                    prevLists[Y].Add(X);
                    nextLists[X].Add(Y);
                    inDegrees[Y]++;
                }

                int W = ReadInt(sr);

                Queue<int> queue = new();
                int[] timeCost = new int[N + 1];

                for (int i = 1; i <= N; i++)
                    if (inDegrees[i] == 0)
                        queue.Enqueue(i);

                while (queue.Count > 0)
                {
                    int B = queue.Dequeue();

                    int fitTime = 0;
                    foreach (int prevB in prevLists[B])
                        fitTime = Math.Max(fitTime, timeCost[prevB]);

                    timeCost[B] = fitTime + D[B];

                    if (B == W) break;

                    foreach (int nextB in nextLists[B])
                        if (--inDegrees[nextB] == 0)
                            queue.Enqueue(nextB);
                }

                sw.WriteLine(timeCost[W]);
            }

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
