namespace Algorithm.BOJ.BOJ_28092
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28092/input1.txt",
            "BOJ/BOJ_28092/input2.txt",
            "BOJ/BOJ_28092/input3.txt",
            "BOJ/BOJ_28092/input4.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), Q = ReadInt(sr);

            int[] root = new int[N + 1];
            Array.Fill(root, -1);

            SortedSet<int> sizeSet = new();
            Dictionary<int, PriorityQueue<int, int>> treePrQueues = new();
            int minNode = 1;

            while (Q-- > 0)
            {
                if (ReadInt(sr) == 1)
                {
                    int u = ReadInt(sr), v = ReadInt(sr);
                    Union(u, v);
                }
                else
                {
                    int n = RemoveMax();
                    sw.WriteLine(n);
                }
            }

            sr.Close();
            sw.Close();

            void Union(int a, int b)
            {
                a = Find(a);
                b = Find(b);

                if (a == b)
                {
                    root[a] = 0;
                    return;
                }

                if (a > b)
                    (a, b) = (b, a);

                root[a] += root[b];
                root[b] = a;

                int size = -root[a];
                treePrQueues.TryAdd(size, new());
                treePrQueues[size].Enqueue(a, a);
                sizeSet.Add(size);
            }

            int Find(int a)
            {
                if (root[a] == 0)
                    return 0;
                if (root[a] < 0)
                    return a;
                return root[a] = Find(root[a]);
            }

            int RemoveMax()
            {
                while (sizeSet.Count > 0)
                {
                    while (treePrQueues[sizeSet.Max].Count > 0)
                    {
                        int a = treePrQueues[sizeSet.Max].Dequeue();
                        if (Find(a) != 0)
                        {
                            root[a] = 0;
                            return a;
                        }
                    }
                    treePrQueues.Remove(sizeSet.Max);
                    sizeSet.Remove(sizeSet.Max);
                }

                while (Find(minNode) == 0)
                    minNode++;

                root[minNode] = 0;
                return minNode;
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
